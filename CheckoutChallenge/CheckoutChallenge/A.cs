using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class A : Product
    {
        public A(Product product)
            : base(product.SKU="A",product.cost=50)
        {
            Basket.ACount++;

        }
    }
}
