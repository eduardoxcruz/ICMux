using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mux;
using Mux.Model;
using Xunit;

namespace UnitTests.Tables
{
    public class EncapsulationTypes
    {
        [Theory]
        [InlineData("TO-220", "3.9mm")]
        [InlineData("SOIC-14", "7mm")]
        [InlineData("DIP-6", "4mm")]
        public void AddNewEncapsulationTypesShouldOk(string name, string bodyWidth)
        {
            using ICContext icContext = new();
            EncapsulationType newEncapsulationType = new() { Name = name, BodyWidth = bodyWidth};
            int previousCount = GetDataCountFromTable();
            icContext.EncapsulationTypes.Add(newEncapsulationType);
            icContext.SaveChanges();
            int newCount = GetDataCountFromTable();
            Assert.True(previousCount < newCount);
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void DeleteEncapsulationTypeIdShouldOk(int id)
        {
            using ICContext icContext = new();
            var encapsulation = GetEncapsulationType(id);
            int previousCount = GetDataCountFromTable();
            icContext.EncapsulationTypes.Remove(encapsulation);
            icContext.SaveChanges();
            int newCount = GetDataCountFromTable();
            Assert.True(newCount < previousCount);
        }
        
        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        public void InsertExplicitIdentityShouldFail(int id)
        {
            string expectedExceptionMessage =
                "No se puede insertar un valor explícito en la columna de identidad de la tabla 'EncapsulationTypes' cuando IDENTITY_INSERT es OFF.";
            Action action = () => InsertNewEncapsulationType(id, $"Name {id}", $"Body {id}");
            DbUpdateException originalException = Assert.Throws<DbUpdateException>(action);
            Assert.Equal(expectedExceptionMessage, originalException.InnerException!.Message);
        }
        
        [Theory]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 3)]
        public void InsertProductIntoProductsListShouldOk(int etId, int productId)
        {
            using ICContext icContext = new();
            var encapsulationType = GetEncapsulationType(etId);
            var product = GetProduct(productId);
            var previousCount = encapsulationType.Products.Count();
            encapsulationType.Products.Add(product);
            icContext.Entry(encapsulationType).State = EntityState.Modified;
            icContext.Entry(product).State = EntityState.Modified;
            icContext.SaveChanges();
            var newCount = GetEncapsulationType(etId).Products.Count();
            
            Assert.True(previousCount < newCount);
        }
        
        [Theory]
        [InlineData(4, 2)]
        [InlineData(5, 2)]
        [InlineData(6, 2)]
        public void UpdateEncapsulationTypeOfExistingProductShouldOk(int productId, int etId)
        {
            using ICContext icContext = new();
            var product = GetProduct(productId);
            product.EncapsulationTypeId = etId;
            icContext.Entry(product).State = EntityState.Modified;
            icContext.SaveChanges();
            var updatedITId = GetProduct(productId).EncapsulationTypeId;
            Assert.True(etId == updatedITId);
        }
        
        private int GetDataCountFromTable()
        {
            using ICContext icContext = new();
            return icContext.EncapsulationTypes.Count();
        }
        
        private EncapsulationType GetEncapsulationType(int id)
        {
            using ICContext icContext = new();
            return icContext.EncapsulationTypes
                .Include(e => e.Products)
                .FirstOrDefault(e => e.Id == id);
        }
        
        private void InsertNewEncapsulationType(int id, string name, string body)
        {
            using ICContext icContext = new();
            var encapsulationType = new EncapsulationType() {Id = id, Name = name, BodyWidth = body};
            icContext.EncapsulationTypes.Add(encapsulationType);
            icContext.SaveChanges();
        }
        
        private Product GetProduct(int id)
        {
            using ICContext icContext = new();
            return icContext.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
