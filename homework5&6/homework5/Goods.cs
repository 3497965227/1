using System;
namespace homework5
{
    public class Goods
    {
        public int Id { get; set; }
        public string GoodsName { get; set; }
        public int Price { get; set; }
        public Goods(int id,string goodsName,int price)
        {
            this.Id = id;
            this.GoodsName = goodsName;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"goodsId:{Id}, GoodsName:{GoodsName},goodsPrice";
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
