using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class D : Product
    {
        public D(Product product)
           : base(product.SKU = "D", product.cost = 20)
        {
            Basket.DCount++;
        }
    }
}
