using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mux;
using Mux.Model;
using Xunit;

namespace UnitTests.Tables;

public class ProductsTest : IClassFixture<ICDatabaseFixture>
{
    private ICDatabaseFixture Fixture { get; }

    public ProductsTest(ICDatabaseFixture fixture)
    {
        Fixture = fixture;
    }

    [Fact]
    public void CreateNewProductShouldOk()
    {
        using ICContext context = Fixture.CreateContext();

        int actualProductId = GetLastProductInDb().Id;
        int expectedId = actualProductId + 1;
        Product newProduct = new() {Id = expectedId};
        context.Products.Add(newProduct);
        context.SaveChanges();
        actualProductId = context.Products.Single(product => product.Id == expectedId).Id;
        Assert.Equal(expectedId, actualProductId);
    }

    [Fact]
    public void InsertProductWithIdZeroShouldOk()
    {
        using ICContext context = Fixture.CreateContext();

        Product newProduct = new();
        context.Products.Add(newProduct);
        context.SaveChanges();
        
        int actualProductId = context.Products.Single(product => product.Id == 0).Id;
        
        Assert.Equal(0, actualProductId);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(6847)]
    public void InsertExistingProductShouldThrowException(int existingProductId)
    {
        string expectedExceptionMessage = 
            $"Infracción de la restricción PRIMARY KEY 'PK_Products'. No se puede insertar una clave duplicada en el objeto 'dbo.Products'. El valor de la clave duplicada es ({existingProductId}).\r\nSe terminó la instrucción.";
        
        Action action = () =>
        {
            using ICContext context = Fixture.CreateContext();
            Product newProduct = new() {Id = existingProductId};
            context.Products.Add(newProduct);
            context.SaveChanges();
        };

        DbUpdateException updateException = Assert.Throws<DbUpdateException>(action);
        Assert.Equal(expectedExceptionMessage, updateException.InnerException!.Message);
    }
    
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void GetProductShouldOk(int expectedProductId)
    {
        using ICContext context = Fixture.CreateContext();
        int actualProductId = GetProductById(expectedProductId).Id;
        Assert.Equal(expectedProductId, actualProductId);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(6847)]
    public void UpdateProductShoulOk(int productId)
    {
        using ICContext context = Fixture.CreateContext();
        string expectedStatus = "OBSOLETO";
        
        Product product = GetProductById(productId);
        product.Status = expectedStatus;
        context.Entry(product).State = EntityState.Modified;
        context.SaveChanges();

        product = GetProductById(productId);
        Assert.Equal(expectedStatus, product.Status);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(6847)]
    public void DeleteProductsShouldOk(int productId)
    {
        using ICContext context = Fixture.CreateContext();
        string expectedExceptionMessage = "Sequence contains no elements";
        
        Product product = GetProductById(productId);
        context.Products.Remove(product);
        context.SaveChanges();
        
        Action action = () =>
        {
            GetProductById(productId);
        };

        InvalidOperationException updateException = Assert.Throws<InvalidOperationException>(action);
        Assert.Equal(expectedExceptionMessage, updateException.Message);
    }

    private Product GetLastProductInDb()
    {
        using ICContext context = Fixture.CreateContext();
        
        return context.Products.OrderByDescending(product => product.Id).First();
    }
    
    private Product GetProductById(int productId)
    {
        using ICContext context = Fixture.CreateContext();
        
        return context.Products.Single(product => product.Id == productId);
    }
}