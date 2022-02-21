using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Mux;
using Mux.Model;
using Xunit;
using Xunit.Sdk;

namespace UnitTests.Tables
{
    public class Categories
    {
        [Theory]
        [InlineData("Leds")]
        [InlineData("Semiconductores")]
        [InlineData("Transistores")]
        public void InsertNewCategoryWithoutProductResultOk(string categoryName)
        {
            using ICContext icContext = new();
            int previousCount = icContext.Categories.Count();
            InsertNewCategoryIntoTable(categoryName);
            int newCount = icContext.Categories.Count();
            Assert.True(previousCount < newCount);
        }

        void InsertNewCategoryIntoTable(string name)
        {
            using ICContext icContext = new();
            var newCategory = new Category() { Name = name };
            icContext.Categories.Add(newCategory);
            icContext.SaveChanges();
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(1,2)]
        [InlineData(1,3)]
        public void AddProductRelationshipShouldOk(int categoryId, int productId)
        {
            using ICContext icContext = new();
            int previousProductsCount = GetProductsInCategoryCount(categoryId);
            InsertNewProductToCategoryProductsList(categoryId, productId);
            int newProductsCount = GetProductsInCategoryCount(categoryId);
            Assert.True(previousProductsCount < newProductsCount);
        }
        
        private int GetProductsInCategoryCount(int categoryId)
        {
            var categoryLoad = GetCategory(categoryId);
            return categoryLoad!.Products.Count;
        }

        private void InsertNewProductToCategoryProductsList(int categoryId, int productId)
        {
            using ICContext icContext = new();
            var category = GetCategory(categoryId);
            var product = GetProduct(productId);
            category.Products.Add(product);
            icContext.Entry(product).State = EntityState.Modified;
            icContext.Entry(category).State = EntityState.Modified;
            icContext.SaveChanges();
        }
        
        private Category GetCategory(int id)
        {
            using ICContext icContext = new();
            var category = icContext.Categories
                .Include(category => category.Products)
                .FirstOrDefault(category => category.Id == id);

            if (category == null)
            {
                throw new NotNullException();
            }

            return category;
        }

        private Product GetProduct(int id)
        {
            using ICContext icContext = new();
            var product = icContext.Products.FirstOrDefault(category => category.Id == id);

            if (product == null)
            {
                throw new NotNullException();
            }

            return product;
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void InsertExplicitIdentityShouldThrowException(int id)
        {
            string expectedExceptionMessage =
                "No se puede insertar un valor explícito en la columna de identidad de la tabla 'Categories' cuando IDENTITY_INSERT es OFF.";
            Action action = () => InsertNewCategoryIntoTable(id, $"Tabla {id}");
            DbUpdateException originalException = Assert.Throws<DbUpdateException>(action);
            Assert.Equal(expectedExceptionMessage, originalException.InnerException!.Message);
        }
        
        void InsertNewCategoryIntoTable(int id, string name)
        {
            using ICContext icContext = new();
            var newCategory = new Category() { Id = id, Name = name };
            icContext.Categories.Add(newCategory);
            icContext.SaveChanges();
        }
    }
}
