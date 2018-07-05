using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class B : Product
    {
        public B(Product product)
           : base(product.SKU = "B", product.cost = 30)
        {
            Basket.BCount++;
        }
    }
}
