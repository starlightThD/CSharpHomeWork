using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment6
{
        class OrderDeatils
        {
            protected int OrderId { get; set; }
            protected string OrderName { get; set; } = string.Empty;
            protected string OrderCustomer { get; set; } = string.Empty;
            protected int OrderAmount { get; set; }
        }
        class Order : OrderDeatils
        {
            public Order(int OrderId, string OrderName, string OrderCustomer, int OrderAmount)
            {
                this.OrderId = OrderId;
                this.OrderName = OrderName;
                this.OrderCustomer = OrderCustomer;
                this.OrderAmount = OrderAmount;
            }
            public int getOrderId()
            {
                return OrderId;
            }
            public string getOrderName()
            {
                return OrderName;
            }
            public string getOrderCustomer()
            {
                return OrderCustomer;
            }
            public int getOrderAmount()
            {
                return OrderAmount;
            }
            public void setOrderId(int OrderId)
            {
                this.OrderId = OrderId;
            }
            public void setOrderName(string OrderName)
            {
                this.OrderName = OrderName;
            }
            public void setOrderCustomer(string OrderCustomer)
            {
                this.OrderCustomer = OrderCustomer;
            }
            public void setOrderAmount(int OrderAmount)
            {
                this.OrderAmount = OrderAmount;
            }
            public override bool Equals(object? obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                Order other = (Order)obj;
                return this.OrderId == other.getOrderId() && this.OrderName == other.getOrderName() && this.OrderCustomer == other.getOrderCustomer() && this.OrderAmount == other.getOrderAmount();
            }
            public override string ToString()
            {
                return "OrderId: " + OrderId + ", OrderName: " + OrderName + ", OrderCustomer: " + OrderCustomer + ", OrderAmount: " + OrderAmount + '\n';
            }

            public override int GetHashCode()
            {
                throw new NotImplementedException();
            }
        }

        class OrderService
        {
            private List<Order> OrderList = new List<Order>();

            public List<Order> getOrderList()
            {
                return OrderList;
            }
            public void AddOrder()
            {
                Console.WriteLine("Enter Order Id: ");
                int OrderId = 0;
                int.TryParse(Console.ReadLine(), out OrderId);
                Console.WriteLine("Enter Order Name: ");
                string OrderName = Console.ReadLine() ?? string.Empty; ;
                Console.WriteLine("Enter Order Customer: ");
                string OrderCustomer = Console.ReadLine() ?? string.Empty; ;
                Console.WriteLine("Enter Order Amount: ");
                int OrderAmount = 0;
                int.TryParse(Console.ReadLine(), out OrderAmount);
                Order Order = new Order(OrderId, OrderName, OrderCustomer, OrderAmount);
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (OrderList[i] == Order)
                    {
                        Console.WriteLine("Order Already Exists.");
                        return;
                    }
                }
                OrderList.Add(Order);
                Console.WriteLine("Order Added Successfully.");
            }
            public void AddOrder(int OrderId, string OrderName, string OrderCustomer, int OrderAmount)
            {
                Order Order = new Order(OrderId, OrderName, OrderCustomer, OrderAmount);
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (OrderList[i] == Order)
                    {
                        Console.WriteLine("Order Already Exists.");
                        return;
                    }
                }
                OrderList.Add(Order);
                Console.WriteLine("Order Added Successfully.");
            }
            public void DeleteOrder()
            {
                Console.WriteLine("Enter Order Id to Delete: ");
                int deleteId = 0;
                int.TryParse(Console.ReadLine(), out deleteId);
                bool isDeleted = false;
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (OrderList[i].getOrderId() == deleteId)
                    {
                        Console.WriteLine("Find Order, Ensure To Delete It?(y/n)");
                        string input = Console.ReadLine() ?? string.Empty; ;
                        if (input.ToLower() != "n" || input.ToLower() != "no")
                        {
                            OrderList.RemoveAt(i);
                            isDeleted = true;
                        }
                        break;
                    }
                }
                if (isDeleted)
                {
                    Console.WriteLine("Order Deleted Successfully.");
                }
                else
                {
                    throw new InvalidOperationException("No Order Deleted.");
                }
            }
            public void DeleteOrder(int OrderId)
            {
                bool isDeleted = false;
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (OrderList[i].getOrderId() == OrderId)
                    {
                        Console.WriteLine("Find Order, Ensure To Delete It?(y/n)");
                        string input = Console.ReadLine() ?? string.Empty; ;
                        if (input.ToLower() != "n" || input.ToLower() != "no")
                        {
                            OrderList.RemoveAt(i);
                            isDeleted = true;
                        }
                        break;
                    }
                }
                if (isDeleted)
                {
                    Console.WriteLine("Order Deleted Successfully.");
                }
                else
                {
                    throw new InvalidOperationException("No Order Deleted.");
                }
            }
            public void ChangeOrder()
            {
                Console.WriteLine("Enter Order Id to Change: ");
                int OrderId = 0;
                int.TryParse(Console.ReadLine(), out OrderId);
                bool isChanged = false;
                for (int i = 0; i < OrderList.Count; i++)
                {
                    if (OrderList[i].getOrderId() == OrderId)
                    {
                        Console.WriteLine("Find Order, Change Order Name?(input empty to skip).");
                        string OrderName = Console.ReadLine() ?? string.Empty; ;
                        if (!string.IsNullOrEmpty(OrderName))
                        {
                            OrderList[i].setOrderName(OrderName);
                            isChanged = true;
                        }
                        Console.WriteLine("Change Order Customer?(input empty to skip)");
                        string OrderCustomer = Console.ReadLine() ?? string.Empty; ;
                        if (!string.IsNullOrEmpty(OrderCustomer))
                        {
                            OrderList[i].setOrderCustomer(OrderCustomer);
                            isChanged = true;
                        }
                        Console.WriteLine("Change Order Amount?(input empty to skip)");
                        string inputOrderAmount = Console.ReadLine() ?? string.Empty; ;
                        if (int.TryParse(inputOrderAmount, out int OrderAmount))
                        {
                            OrderList[i].setOrderAmount(OrderAmount);
                            isChanged = true;
                        }
                        break;
                    }
                }
                if (isChanged)
                {
                    Console.WriteLine("Order Changed Successfully.");
                }
                else
                {
                    throw new InvalidOperationException("Nothing Changed.");
                }
            }
            public void sortOrderList(List<Order> orderList, string sortType)
            {
                switch (sortType)
                {
                    case "OrderId":
                        orderList.Sort((x, y) => x.getOrderId().CompareTo(y.getOrderId()));
                        break;
                    case "OrderName":
                        orderList.Sort((x, y) => x.getOrderName().CompareTo(y.getOrderName()));
                        break;
                    case "OrderCustomer":
                        orderList.Sort((x, y) => x.getOrderCustomer().CompareTo(y.getOrderCustomer()));
                        break;
                    case "OrderAmount":
                        orderList.Sort((x, y) => x.getOrderAmount().CompareTo(y.getOrderAmount()));
                        break;
                }
            }
            public void sortOrderList(List<Order> orderList, Comparison<Order> comparer)
            {
                orderList.Sort(comparer);
            }  
            public List<Order> SearchOrderLINQ()
            {
                Console.WriteLine("Which Order Information to Search?(1-OrderId, 2-OrderName, 3-OrderCustomer, 4-OrderAmount):");
                string input = Console.ReadLine() ?? string.Empty;
                if (int.TryParse(input, out int searchType) && searchType >= 1 && searchType <= 4)
                {
                    Console.WriteLine("Enter Search Value:");
                    string searchValue = Console.ReadLine() ?? string.Empty;
                    List<Order> searchResult = new List<Order>();

                    switch (searchType)
                    {
                        case 1:
                            if (int.TryParse(searchValue, out int orderIdValue))
                            {   //filter and convert to list
                                searchResult = OrderList.Where(o => o.getOrderId() == orderIdValue).ToList();
                            }
                            break;
                        case 2:
                            searchResult = OrderList.Where(o => o.getOrderName() == searchValue).ToList();
                            break;
                        case 3:
                            searchResult = OrderList.Where(o => o.getOrderCustomer() == searchValue).ToList();
                            break;
                        case 4:
                            if (int.TryParse(searchValue, out int orderAmountValue))
                            {
                                searchResult = OrderList.Where(o => o.getOrderAmount() == orderAmountValue).ToList();
                            }
                            break;
                    }

                    if (searchResult.Count > 0)
                    {
                        Console.WriteLine("Get Search Result.");
                        sortOrderList(searchResult, "OrderAmount");
                        return searchResult;
                    }
                    else
                    {
                        Console.WriteLine("No Result Found.");
                    return null;
                }
                }
                else
                {
                    throw new InvalidOperationException("Invalid Input.");
                }
                return new List<Order>();
            }
            public List<Order> SearchOrderLINQ(int searchType, string searchValue)
            {
                List<Order> searchResult = new List<Order>();

                switch (searchType)
                {
                    case 1:
                        if (int.TryParse(searchValue, out int orderIdValue))
                        {   //filter and convert to list
                            searchResult = OrderList.Where(o => o.getOrderId() == orderIdValue).ToList();
                        }
                        break;
                    case 2:
                        searchResult = OrderList.Where(o => o.getOrderName() == searchValue).ToList();
                        break;
                    case 3:
                        searchResult = OrderList.Where(o => o.getOrderCustomer() == searchValue).ToList();
                        break;
                    case 4:
                        if (int.TryParse(searchValue, out int orderAmountValue))
                        {
                            searchResult = OrderList.Where(o => o.getOrderAmount() == orderAmountValue).ToList();
                        }
                        break;
                }

                if (searchResult.Count > 0)
                {
                    Console.WriteLine("Get Search Result.");
                    sortOrderList(searchResult, "OrderAmount");
                    return searchResult;
                }
                else
                {
                    Console.WriteLine("No Result Found.");
                    return null;
                }
                return new List<Order>();
            }
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Order Management System Start.");
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            OrderService orderService = new OrderService();
            Console.WriteLine("Initial Manager.");
        }
    }
}