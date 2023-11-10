using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1
{
    public class Burger :Product
    {
        public List<Option> Options { get; set; }
        public override double Price
        {
            get
            {
                double priceOption = 0;
                foreach (var option in Options)
                {
                    priceOption += option.Price;
                }
                return BasePrice + priceOption;
            }
        }
    }
}
