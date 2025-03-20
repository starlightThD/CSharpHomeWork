using System;
using assignment5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrderService orderService;
        [TestInitialize]
        public void SetUp()
        {
            orderService = new OrderService();
        }
        [TestMethod]
        public void AddOrder_ShouldAddOrderSuccessfully()
        {
            // Arrange
            int orderId = 1;
            string orderName = "Book";
            string orderCustomer = "John";
            int orderAmount = 50;

            // Act
            orderService.AddOrder(orderId, orderName, orderCustomer, orderAmount);
            List<Order> orders = orderService.getOrderList();

            // Assert
            Assert.AreEqual(1, orders.Count);
            Assert.AreEqual(orderId, orders[0].getOrderId());
            Assert.AreEqual(orderName, orders[0].getOrderName());
            Assert.AreEqual(orderCustomer, orders[0].getOrderCustomer());
            Assert.AreEqual(orderAmount, orders[0].getOrderAmount());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteOrder_ShouldThrowExceptionWhenOrderNotFound()
        {
            // Act
            orderService.DeleteOrder(999);
        }

        [TestMethod]
        public void DeleteOrder_ShouldDeleteOrderSuccessfully()
        {
            // Arrange
            int orderId = 1;
            orderService.AddOrder(orderId, "Book", "John", 50);

            // Act
            orderService.DeleteOrder(orderId);
            List<Order> orders = orderService.getOrderList();

            // Assert
            Assert.AreEqual(0, orders.Count);
        }

        [TestMethod]
        public void ChangeOrder_ShouldChangeOrderSuccessfully()
        {
            // Arrange
            int orderId = 1;
            orderService.AddOrder(orderId, "Book", "John", 50);

            // Act
            orderService.ChangeOrder();
            List<Order> orders = orderService.getOrderList();

            // Assert
            // 这里假设用户输入了新的订单名称、客户和金额
            Assert.AreEqual("NewName", orders[0].getOrderName());
            Assert.AreEqual("NewCustomer", orders[0].getOrderCustomer());
            Assert.AreEqual(100, orders[0].getOrderAmount());
        }

        [TestMethod]
        public void SearchOrderLINQ_ShouldReturnCorrectOrders()
        {
            // Arrange
            orderService.AddOrder(1, "Book", "John", 50);
            orderService.AddOrder(2, "Pen", "Mary", 30);
            orderService.AddOrder(3, "Pencil", "Mary", 20);

            // Act
            List<Order> result = orderService.SearchOrderLINQ(3, "Mary");

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Pen", result[0].getOrderName());
            Assert.AreEqual("Pencil", result[1].getOrderName());
        }
    }
}
