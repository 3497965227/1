﻿using System;
using System.Collections.Generic;

namespace homework5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new Customer(1, "Customer1");
                Customer customer2 = new Customer(2, "Customer2");

                Goods milk = new Goods(1, "Milk", 69);
                Goods eggs = new Goods(2, "eggs", 4);
                Goods apple = new Goods(3, "apple", 5);

                Order order1 = new Order(1, customer1);
                order1.AddOrderDetail(new OrderDetail(apple, 8));
                order1.AddOrderDetail(new OrderDetail(eggs, 10));
                //order1.AddDetails(new OrderDetail(eggs, 8));
                //order1.AddDetails(new OrderDetail(milk, 10));

                Order order2 = new Order(2, customer2);
                order2.AddOrderDetail(new OrderDetail(eggs, 10));
                order2.AddOrderDetail(new OrderDetail(milk, 10));

                Order order3 = new Order(3, customer2);
                order3.AddOrderDetail(new OrderDetail(milk, 100));

                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                orderService.AddOrder(order3);

                Console.WriteLine("\n GetById");
                Console.WriteLine(orderService.GetById(1));
                Console.WriteLine(orderService.GetById(5) == null);

                Console.WriteLine("\nGetAllOrders");
                List<Order> orders = orderService.QueryAll();
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersByCustomerName:'Customer2'");
                orders = orderService.QueryByCustomerName("Customer2");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersByGoodsName:'eggs'");
                orders = orderService.QueryByGoodsName("eggs");
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nGetOrdersTotalAmount:1000");
                orders = orderService.QueryByTotalPrice(1000);
                orders.ForEach(o => Console.WriteLine(o));

                Console.WriteLine("\nRemove order(id=2) and qurey all");
                orderService.RemoveOrder(2);
                orderService.QueryAll().ForEach(
                    o => Console.WriteLine(o));

                Console.WriteLine("\nOrder by order ID");
                orderService.Sort().ForEach(
                    o => Console.WriteLine(o));

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
