using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;

namespace assignment8
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; } // Add this property as the primary key
        public int Index { get; set; } = 0;
        public string ItemName { get; set; } = string.Empty;
        public int Number { get; set; } = 0;
        public int Amount { get; set; } = 0;

        public OrderDetails() { }
        public OrderDetails(int index, string itemName, int number, int amount)
        {
            Index = index;
            ItemName = itemName;
            Number = number;
            Amount = amount;
        }

        internal object[] getIndex()
        {
            throw new NotImplementedException();
        }

        internal object getItemName()
        {
            throw new NotImplementedException();
        }

        internal object getNumber()
        {
            throw new NotImplementedException();
        }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; } = string.Empty;
        public string OrderCustomer { get; set; } = string.Empty;
        public int OrderAmount { get; set; }

        public List<OrderDetails> OrderDetailsList { get; set; } = new List<OrderDetails>();

        public Order(int orderId, string orderName, string orderCustomer, int orderAmount)
        {
            OrderId = orderId;
            OrderName = orderName;
            OrderCustomer = orderCustomer;
            OrderAmount = orderAmount;
        }

        public Order() { }

        public void AddOrderDetails(int index, string itemName, int number, int amount)
        {
            OrderDetails orderDetails = new OrderDetails(index, itemName, number, amount);
            OrderDetailsList.Add(orderDetails);
        }

        public void SetOrderAmount()
        {
            OrderAmount = OrderDetailsList.Sum(order => order.Amount);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Order other = (Order)obj;
            return OrderId == other.OrderId && OrderName == other.OrderName && OrderCustomer == other.OrderCustomer && OrderAmount == other.OrderAmount;
        }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, OrderName: {OrderName}, OrderCustomer: {OrderCustomer}, OrderAmount: {OrderAmount}\n";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId, OrderName, OrderCustomer, OrderAmount);
        }
    }

    public class OrderService
    {
        public List<Order> GetOrderList()
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include(o => o.OrderDetailsList).AsNoTracking().ToList();
            }
        }

        public void AddOrder()
        {
            Console.WriteLine("Enter Order Id: ");
            int.TryParse(Console.ReadLine(), out int orderId);
            Console.WriteLine("Enter Order Name: ");
            string orderName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter Order Customer: ");
            string orderCustomer = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter Order Amount: ");
            int.TryParse(Console.ReadLine(), out int orderAmount);
            Order order = new Order(orderId, orderName, orderCustomer, orderAmount);

            using (var context = new OrderContext())
            {
                if (context.Orders.Any(o => o.OrderId == orderId))
                {
                    Console.WriteLine("Order Already Exists.");
                    return;
                }
                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("Order Added Successfully.");
            }
        }

        public void AddOrder(int orderId, string orderName, string orderCustomer, int orderAmount)
        {
            Order order = new Order(orderId, orderName, orderCustomer, orderAmount);

            using (var context = new OrderContext())
            {
                if (context.Orders.Any(o => o.OrderId == orderId))
                {
                    Console.WriteLine("Order Already Exists.");
                    return;
                }
                context.Orders.Add(order);
                context.SaveChanges();
                Console.WriteLine("Order Added Successfully.");
            }
        }

        public void DeleteOrder()
        {
            Console.WriteLine("Enter Order Id to Delete: ");
            int.TryParse(Console.ReadLine(), out int deleteId);

            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(o => o.OrderDetailsList).SingleOrDefault(o => o.OrderId == deleteId);
                if (order != null)
                {
                    Console.WriteLine("Find Order, Ensure To Delete It?(y/n)");
                    string input = Console.ReadLine() ?? string.Empty;
                    if (input.ToLower() != "n" && input.ToLower() != "no")
                    {
                        context.Orders.Remove(order);
                        context.SaveChanges();
                        Console.WriteLine("Order Deleted Successfully.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("No Order Deleted.");
                }
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(o => o.OrderDetailsList).SingleOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    Console.WriteLine("Find Order, Ensure To Delete It?(y/n)");
                    string input = Console.ReadLine() ?? string.Empty;
                    if (input.ToLower() != "n" && input.ToLower() != "no")
                    {
                        context.Orders.Remove(order);
                        context.SaveChanges();
                        Console.WriteLine("Order Deleted Successfully.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("No Order Deleted.");
                }
            }
        }

        public void ChangeOrder()
        {
            Console.WriteLine("Enter Order Id to Change: ");
            int.TryParse(Console.ReadLine(), out int orderId);

            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(o => o.OrderDetailsList).SingleOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    bool isChanged = false;
                    Console.WriteLine("Find Order, Change Order Name?(input empty to skip).");
                    string orderName = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(orderName))
                    {
                        order.OrderName = orderName;
                        isChanged = true;
                    }
                    Console.WriteLine("Change Order Customer?(input empty to skip)");
                    string orderCustomer = Console.ReadLine() ?? string.Empty;
                    if (!string.IsNullOrEmpty(orderCustomer))
                    {
                        order.OrderCustomer = orderCustomer;
                        isChanged = true;
                    }
                    Console.WriteLine("Change Order Amount?(input empty to skip)");
                    string inputOrderAmount = Console.ReadLine() ?? string.Empty;
                    if (int.TryParse(inputOrderAmount, out int orderAmount))
                    {
                        order.OrderAmount = orderAmount;
                        isChanged = true;
                    }

                    if (isChanged)
                    {
                        context.SaveChanges();
                        Console.WriteLine("Order Changed Successfully.");
                    }
                    else
                    {
                        throw new InvalidOperationException("Nothing Changed.");
                    }
                }
                else
                {
                    throw new InvalidOperationException("Order Not Found.");
                }
            }
        }

        public void SortOrderList(List<Order> orderList, string sortType)
        {
            switch (sortType)
            {
                case "OrderId":
                    orderList.Sort((x, y) => x.OrderId.CompareTo(y.OrderId));
                    break;
                case "OrderName":
                    orderList.Sort((x, y) => x.OrderName.CompareTo(y.OrderName));
                    break;
                case "OrderCustomer":
                    orderList.Sort((x, y) => x.OrderCustomer.CompareTo(y.OrderCustomer));
                    break;
                case "OrderAmount":
                    orderList.Sort((x, y) => x.OrderAmount.CompareTo(y.OrderAmount));
                    break;
            }
        }

        public void SortOrderList(List<Order> orderList, Comparison<Order> comparer)
        {
            orderList.Sort(comparer);
        }

        public List<Order>? SearchOrderLINQ()
        {
            Console.WriteLine("Which Order Information to Search?(1-OrderId, 2-OrderName, 3-OrderCustomer, 4-OrderAmount):");
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int searchType) && searchType >= 1 && searchType <= 4)
            {
                Console.WriteLine("Enter Search Value:");
                string searchValue = Console.ReadLine() ?? string.Empty;
                List<Order> searchResult = new List<Order>();

                using (var context = new OrderContext())
                {
                    switch (searchType)
                    {
                        case 1:
                            if (int.TryParse(searchValue, out int orderIdValue))
                            {
                                searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderId == orderIdValue).ToList();
                            }
                            break;
                        case 2:
                            searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderName == searchValue).ToList();
                            break;
                        case 3:
                            searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderCustomer == searchValue).ToList();
                            break;
                        case 4:
                            if (int.TryParse(searchValue, out int orderAmountValue))
                            {
                                searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderAmount == orderAmountValue).ToList();
                            }
                            break;
                    }

                    if (searchResult.Count > 0)
                    {
                        Console.WriteLine("Get Search Result.");
                        SortOrderList(searchResult, "OrderAmount");
                        return searchResult;
                    }
                    else
                    {
                        Console.WriteLine("No Result Found.");
                        return null;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("Invalid Input.");
            }
        }

        public List<Order>? SearchOrderLINQ(int searchType, string searchValue)
        {
            List<Order> searchResult = new List<Order>();

            using (var context = new OrderContext())
            {
                switch (searchType)
                {
                    case 1:
                        if (int.TryParse(searchValue, out int orderIdValue))
                        {
                            searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderId == orderIdValue).ToList();
                        }
                        break;
                    case 2:
                        searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderName == searchValue).ToList();
                        break;
                    case 3:
                        searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderCustomer == searchValue).ToList();
                        break;
                    case 4:
                        if (int.TryParse(searchValue, out int orderAmountValue))
                        {
                            searchResult = context.Orders.Include(o => o.OrderDetailsList).Where(o => o.OrderAmount == orderAmountValue).ToList();
                        }
                        break;
                }

                if (searchResult.Count > 0)
                {
                    Console.WriteLine("Get Search Result.");
                    SortOrderList(searchResult, "OrderAmount");
                    return searchResult;
                }
                else
                {
                    Console.WriteLine("No Result Found.");
                    return null;
                }
            }
        }
    }

    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=localhost;Database=OrderDB;User=root;Password=142857;";
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));
                optionsBuilder.UseMySql(connectionString, serverVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetailsList)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data
            modelBuilder.Entity<Order>().HasData(
                new Order(1, "Order1", "Customer1", 100),
                new Order(2, "Order2", "Customer2", 200)
            );

            modelBuilder.Entity<OrderDetails>().HasData(
                new OrderDetails(1, "Item1", 1, 50) { Id = 1, Index = 1 },
                new OrderDetails(2, "Item2", 2, 50) { Id = 2, Index = 2 },
                new OrderDetails(3, "Item3", 1, 100) { Id = 3, Index = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }

        [STAThread]
        static void Main()
        {
            Console.WriteLine("Order Management System Start.");
            ApplicationConfiguration.Initialize();

            using (var context = new OrderContext())
            {
                context.Database.EnsureCreated();
            }

            OrderService orderService = new OrderService();
            Console.WriteLine("Initial Manager.");
            Application.Run(new Form1());
        }
    }
}
