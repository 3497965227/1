using System;
using System.Collections.Generic;
using System.Linq;

namespace homework5
{
    public class OrderService
    {
        private List<Order> orderList = new List<Order>();
        public OrderService()
        {
        }
        public void AddOrder(Order order) {
            this.orderList.Add(order);
        }
        public void RemoveOrder(int orderId) {
            this.orderList.RemoveAll((Order order) => order.OrderId == orderId);
        }
        public Order GetById(int orderId)
        {
            return orderList.Where(o => o.OrderId == orderId).FirstOrDefault();
        }

    
        

        public List<Order> QueryAll()
        {
            return orderList;
        }

        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orderList.Where(o => condition(o));
        }
        public void ChangeOrder(Order order) {
            RemoveOrder(order.OrderId);
            AddOrder(order);
        }
        public List<Order> Sort() {
            var orderlist = from o in orderList
                            orderby o.OrderId
                            select o;
            return orderlist.ToList();
        }
        public List<Order> QueryByOrderId(int orderId) {
            var orderlist= orderList.Where(o => o.OrderId == orderId);
            return orderlist.ToList();
      
        }
        public List<Order> QueryByGoodsName(string goodsName) {
            var orderlist = orderList.Where(  o => o.orderDetailList.Any(d => d.Goods.GoodsName == goodsName));
            

            return orderlist.ToList();
                
        }
        public List<Order> QueryByCustomerName(string customerName) {
            var orderlist = orderList.Where(o => o.Customer.CustomerName == customerName);
            return orderlist.ToList();
        }
        public List<Order> QueryByTotalPrice(int price) {
            var orderlist = orderList.Where(o => o.TotalPrice == price);
            return orderlist.ToList();
        }
       
    }
}
