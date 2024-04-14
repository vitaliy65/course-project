using Microsoft.VisualStudio.TestTools.UnitTesting;
using Курсовая_работа.Controller;
using Курсовая_работа.model;

namespace YourNamespace.Tests
{
    [TestClass]
    public class CustomerControllerTests
    {
        [TestMethod]
        public void Add_Customer_Success()
        {
            // Arrange
            var controller = new CustomerController();
            var customer = new Customer { FirstLastName = "", gmail = "test@example.com", password = "11111", phone = "123456789"};

            // Act
            controller.Add(customer);

            // Assert
            var addedCustomer = controller.GetElements().FirstOrDefault(c => c.Id == customer.Id);
            Assert.IsNotNull(addedCustomer);
        }

        [TestMethod]
        public void Remove_CustomerById_Success()
        {
            // Arrange
            var controller = new CustomerController();
            var customer = new Customer { FirstLastName = "", gmail = "test@example.com", password = "11111", phone = "123456789" };
            controller.Add(customer);

            // Act
            controller.RemoveById(customer.Id);

            // Assert
            var removedCustomer = controller.GetElements().FirstOrDefault(c => c.Id == customer.Id);
            Assert.IsNull(removedCustomer);
        }

        [TestMethod]
        public void Change_Customer_Success()
        {
            // Arrange
            var controller = new CustomerController();
            var customer = new Customer { Id = 3013 };

            // Act
            var updatedCustomer = controller.Find(customer);
            updatedCustomer.FirstLastName = "updated";
            controller.Change(updatedCustomer);

            // Assert
            var changedCustomer = controller.GetElements().FirstOrDefault(c => c.Id == updatedCustomer.Id);
            Assert.IsNotNull(changedCustomer);
        }

        // Add more tests as needed for other methods like Remove, Find, etc.
    }
}
