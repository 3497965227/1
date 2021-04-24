using System;
namespace homework5
{
    public class Customer
    {
        public String CustomerName { get; set; }
        public int CustomerId { get; set; }

        public Customer(int customerId, String customerName)
        {
            this.CustomerName = customerName;
            this.CustomerId = customerId;
        }

        public override string ToString()
        {
            return $"customerId:{CustomerId}, CustomerName:{CustomerName}";
        }


    }
}
