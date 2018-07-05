using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    class Program
    {


        static void Main(string[] args)
        {
            string m1 = "Please scan the product(enter the letter; A,B,C or D)";
            string m2 = "You have scanned : ";
            string m3 = "Your total is now : ";
            string m4 = "-------------------------------------------------------";
            string productSKU;
            Boolean running = true;



            Basket basket = new Basket();


            do
            {
                Console.WriteLine(m1);
                productSKU = Console.ReadLine();

                Console.WriteLine("{0}{1}", m2, productSKU);
                basket.Add(productSKU);
                basket.Calculate();

                Console.WriteLine("{0}{1}",m3,Basket.total);
                Console.WriteLine(m4);
                

            } while (running);
            


        }


    }
}
