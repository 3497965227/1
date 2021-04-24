using System;
using System.Collections.Generic;

namespace homework5
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public int TotalPrice { get; }
        
        public List<OrderDetail> orderDetailList = new List<OrderDetail>();

        public Order(int orderId, Customer customer)
        {
            this.OrderId = orderId;
            this.Customer = customer;
            this.CreateTime = DateTime.Now;
        }

        public void AddOrderDetail(OrderDetail orderDetail) {
            this.orderDetailList.Add(orderDetail);
        }
        public void RemoveOrderDetail(int num)
        {
            this.orderDetailList.RemoveAt(num);
        }
        
        public override string ToString()
        {
            String result = $"orderId:{OrderId}, customer:({Customer})";
            orderDetailList.ForEach(detail => result += "\n\t" + detail);
            return result;
        }

        public override int GetHashCode()
        {
            return 2108858624 + OrderId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && OrderId == order.OrderId;
        }

    }
}
