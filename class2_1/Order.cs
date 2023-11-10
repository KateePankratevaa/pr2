using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class2_1
{
    public class Order
    {
        public static int Number = 1;
        public int OrderNumber { get; }
        public DateTime OrderTime{ get; }
        public List<Product> Products { get; }

        public Order ()
        {
            OrderNumber = Number++;
            OrderTime = DateTime.Now;
            Products = new List<Product>();
        }
        public void AddProduct (Product product)
        {
            Products.Add(product);
        }
        public double TotalPrice ()
        {
            double totalprice = 0;
            foreach (var product in Products)
            {
                totalprice += product.Price;
            }
            return totalprice;
        }
        public string GetCheck ()
        {

            
        }


    }
}
