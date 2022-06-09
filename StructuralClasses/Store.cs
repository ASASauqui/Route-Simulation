using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreRoutes
{
    public class Store
    {
        public int storeID { get; set; }
        public string storeName { get; set; }
        public List<ProductOrder> products { get; set; }

        public Store()
        {
            products = new List<ProductOrder>();
        }
    }
}
