using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class C : Product
    {
        public C(Product product)
           : base(product.SKU = "C", product.cost = 70)
        {
            Basket.CCount++;
        }
    }
}
