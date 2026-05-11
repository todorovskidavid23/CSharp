using Class03.Static.Enums;
using Class03.Static.Helpers;
using Class03.Static.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Class03.Static
{
    public static class OrdersStaticDB
    {
        public static List<Order> Orders { get; set; } = new List<Order>();
        public static List<User> Users{ get; set; } = new List<User>();

        private static int orderIdCounter;
        //Ne moze da ima klasicen constructor
        //public OrdersStaticDB()
        //{

        //}

        static OrdersStaticDB()
        {
            ConsoleHelper.WriteInColor("Hello from OrdersStaticDB static constructor",ConsoleColor.DarkMagenta);

            Orders = new List<Order>
            {
                new Order{Id=1,Title="Order 1",Description = "Description for Order 1", Status=OrderStatus.Processing},
                new Order{Id=2,Title="Order 2",Description = "Description for Order 2", Status=OrderStatus.Delivered},
                new Order{Id=3,Title="Order 3",Description = "Description for Order 3", Status=OrderStatus.InProgress},
                new Order{Id=4,Title="Order 4",Description = "Description for Order 4", Status=OrderStatus.Cancelled},
                new Order{Id=5,Title="Order 5",Description = "Description for Order 5", Status=OrderStatus.InProgress},
            };

            Users = new List<User>
            {
                new User{Id=1,Username="bobsky123",Address="Bobsky St."},
                new User{Id=2,Username="john123",Address="John St."},
            };

            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);

            orderIdCounter = Orders.Max(o => o.Id);//za counter 
        }

        public static void ListUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i+1}. {Users[i].Username}");
            }
        }

        public static void InsertOrders(Order order, int userId)
        {
            User user = Users.SingleOrDefault(x => x.Id == userId);
            //firs or default single default mora da e edno takvo ako ima povekje kje frli exeption
            if(user is null)
            {
                ConsoleHelper.WriteError("User not found!");
                return;
            }

            order.Id = ++orderIdCounter; //Auto incrementing the order Id
            Orders.Add(order);
            user.Orders.Add(order);

            ConsoleHelper.WriteInColor($"Order successfully created!", ConsoleColor.Green);
            ConsoleHelper.WriteInColor($"Total number of orders: {Orders.Count}", ConsoleColor.DarkGreen);

        }

    }
}
