using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class Product
    {
        public string SKU;
        public int cost;

        public Product()
        {
        }

        public Product(string pSKU, int pCost)
        {
            SKU = pSKU;
            cost = pCost;
        }
    }
}
