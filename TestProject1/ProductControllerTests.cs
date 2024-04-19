using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace YourNamespace.Tests
{
    [TestClass]
    public class ProductControllerTests
    {
        [TestMethod]
        public void Add_Product_Success()
        {
            // Arrange
            var controller = new ProductController();
            var product = new Product { RestaurantId = 5, FilePathimage = "test", Price = 0, Name = "testName", Description = "TestDescription" };

            // Act
            controller.Add(product);

            // Assert
            var addedProduct = controller.GetElements().FirstOrDefault(p => p.Id == product.Id);
            Assert.IsNotNull(addedProduct);
        }

        [TestMethod]
        public void Remove_ProductById_Success()
        {
            // Arrange
            var controller = new ProductController();
            var product = new Product { RestaurantId = 5, FilePathimage = "test", Price = 0, Name = "testName", Description = "TestDescription" };
            controller.Add(product);

            // Act
            controller.RemoveById(product.Id);

            // Assert
            var removedProduct = controller.GetElements().FirstOrDefault(p => p.Id == product.Id);
            Assert.IsNull(removedProduct);
        }

        [TestMethod]
        public void Change_Product_Success()
        {
            // Arrange
            var controller = new ProductController();
            var product = new Product { RestaurantId = 5, FilePathimage = "test", Price = 0, Name = "testName", Description = "TestDescription" };
            controller.Add(product);

            // Act
            var updatedProduct = controller.Find(product);
            updatedProduct.FilePathimage = "updated_FilePathimage"; // Update some property of the product
            controller.Change(updatedProduct);

            // Assert
            var changedProduct = controller.GetElements().FirstOrDefault(p => p.Id == updatedProduct.Id);
            Assert.IsNotNull(changedProduct);
            // Add more assertions as needed to verify changes
        }

        // Add more tests as needed for other methods like Remove, TryFind, etc.
    }
}
