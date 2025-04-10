using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace assignment8.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new assignment8.Data.assignment8Context(
                serviceProvider.GetRequiredService<DbContextOptions<assignment8.Data.assignment8Context>>()))
            {
                // 检查数据库中是否已经有数据
                if (context.Order.Any())
                {
                    return; // 数据库已被初始化
                }

                // 添加初始数据
                context.Order.AddRange(
                    new Order
                    {
                        OrderName = "Order1",
                        OrderCustomer = "Customer1",
                        OrderAmount = 100,
                        OrderDetailList = new List<OrderDetail>
                        {
                            new OrderDetail { Index = 1, ItemName = "Item1", Number = 2, Amount = 50 },
                            new OrderDetail { Index = 2, ItemName = "Item2", Number = 1, Amount = 50 }
                        }
                    },
                    new Order
                    {
                        OrderName = "Order2",
                        OrderCustomer = "Customer2",
                        OrderAmount = 200,
                        OrderDetailList = new List<OrderDetail>
                        {
                            new OrderDetail { Index = 1, ItemName = "Item3", Number = 4, Amount = 200 }
                        }
                    }
                );

                context.SaveChanges(); // 保存更改
            }
        }
    }
}
