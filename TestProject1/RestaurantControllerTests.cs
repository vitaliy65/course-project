using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace YourNamespace.Tests
{
    [TestClass]
    public class RestaurantControllerTests
    {
        [TestMethod]
        public void Add_Restaurant_Success()
        {
            // Arrange
            var controller = new RestaurantController();
            var restaurant = new Restaurant { FilePathimage = "-", Name = "testname", timeForCustomer = "test_timeForCustomer", Description = "test_Description" };

            // Act
            controller.Add(restaurant);

            // Assert
            var addedRestaurant = controller.GetElements().FirstOrDefault(r => r.Id == restaurant.Id);
            Assert.IsNotNull(addedRestaurant);
        }

        [TestMethod]
        public void Remove_RestaurantById_Success()
        {
            // Arrange
            var controller = new RestaurantController();
            var restaurant = new Restaurant { FilePathimage = "-", Name = "testname", timeForCustomer = "test_timeForCustomer", Description = "test_Description" };
            controller.Add(restaurant);

            // Act
            controller.RemoveById(restaurant.Id);

            // Assert
            var removedRestaurant = controller.GetElements().FirstOrDefault(r => r.Id == restaurant.Id);
            Assert.IsNull(removedRestaurant);
        }

        [TestMethod]
        public void Change_Restaurant_Success()
        {
            // Arrange
            var controller = new RestaurantController();
            var restaurant = new Restaurant { FilePathimage = "-", Name = "testname", timeForCustomer = "test_timeForCustomer", Description = "test_Description" };
            controller.Add(restaurant);

            // Act
            var updatedRestaurant = controller.Find(restaurant);
            updatedRestaurant.Name = "updated_testname"; // Update some property of the restaurant
            controller.Change(updatedRestaurant);

            // Assert
            var changedRestaurant = controller.GetElements().FirstOrDefault(r => r.Id == updatedRestaurant.Id);
            Assert.IsNotNull(changedRestaurant);
            // Add more assertions as needed to verify changes
        }

        // Add more tests as needed for other methods like Remove, TryFind, etc.
    }
}
