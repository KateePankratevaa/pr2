using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1
{
    public class Drink :Product
    {
        public double Volume { get; set; }
        public bool IsBottled { get; set; }
        public override double Price 
        {
            get
            {
                if (IsBottled)
                    return BasePrice + 25;
                else
                    return BasePrice;
            }
        }
    }
}
