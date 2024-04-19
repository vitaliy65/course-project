using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace YourNamespace.Tests
{
    [TestClass]
    public class OrderControllerTests
    {
        [TestMethod]
        public void Add_Order_Success()
        {
            // Arrange
            var controller = new OrderController();
            var Productcontroller = new ProductController();
            var Customercontroller = new CustomerController();
            var product = Productcontroller.FindById(9);
            var customer = Customercontroller.FindById(1003);
            var order = new Order { orderPlaced = DateTime.Today, orderFulfilled = DateTime.Today, CustomerId = customer.Id, ProductId = product.Id };

            // Act
            controller.Add(order);

            // Assert
            var addedOrder = controller.GetElements().FirstOrDefault(o => o.Id == order.Id);
            Assert.IsNotNull(addedOrder);
        }

        [TestMethod]
        public void Remove_OrderById_Success()
        {
            // Arrange
            var controller = new OrderController();
            var Productcontroller = new ProductController();
            var Customercontroller = new CustomerController();
            var product = Productcontroller.FindById(9);
            var customer = Customercontroller.FindById(1003);
            var order = new Order { orderPlaced = DateTime.Today, orderFulfilled = DateTime.Today, CustomerId = customer.Id, ProductId = product.Id };
            controller.Add(order);

            // Act
            controller.RemoveById(order.Id);

            // Assert
            var removedOrder = controller.GetElements().FirstOrDefault(o => o.Id == order.Id);
            Assert.IsNull(removedOrder);
        }

        [TestMethod]
        public void Change_Order_Success()
        {
            // Arrange
            var controller = new OrderController();
            var Productcontroller = new ProductController();
            var Customercontroller = new CustomerController();
            var product = Productcontroller.FindById(9);
            var customer = Customercontroller.FindById(1003);
            var order = new Order { orderPlaced = DateTime.Today, orderFulfilled = DateTime.Today, CustomerId = customer.Id, ProductId = product.Id };
            controller.Add(order);

            // Act
            var updatedOrder = controller.Find(order);
            updatedOrder.orderPlaced = DateTime.Parse("01-01-2025"); // Update some property of the order
            controller.Change(updatedOrder);

            // Assert
            var changedOrder = controller.GetElements().FirstOrDefault(o => o.Id == updatedOrder.Id);
            Assert.IsNotNull(changedOrder);
            // Add more assertions as needed to verify changes
        }

        // Add more tests as needed for other methods like Remove, TryFind, etc.
    }
}
