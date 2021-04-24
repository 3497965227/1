using System;
using System.Collections.Generic;

namespace homework5
{
    public class OrderDetail
    {
        public Goods Goods { get; set; }
        public int Num { get; set; }
        

        
        public OrderDetail(Goods goods,int num)
        {
            this.Num = num;
            this.Goods=goods;
        }
        public override string ToString()
        {
            return $"OrderDetail:{Goods},{Num}";
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
        }
    }
}
