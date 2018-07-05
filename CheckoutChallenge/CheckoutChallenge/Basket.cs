using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutChallenge
{
    public class Basket
    {
        public static int total = 0;
        public static int ACount=0;
        public static int BCount = 0;
        public static int CCount = 0;
        public static int DCount = 0;

        public void Add(string SKU)
        {
            switch (SKU)
            {
                case "A":
                    {
                        Product product = new Product();
                        A a = new A(product);                      

                        break;
                    }
                case "B":
                    {
                        Product product = new Product();
                        B b = new B(product);

                        break;
                    }
                case "C":
                    {
                        Product product = new Product();
                        C c = new C(product);

                        break;
                    }
                case "D":
                    {
                        Product product = new Product();
                        D d = new D(product);

                        break;
                    }

                default:
                    {
                        Console.WriteLine("You have entered an incorrect product key");
                        break;
                    }
                        
                    
            }

        }



        public void Calculate()
        {
            total = 0;

            if(ACount >= 3)
            {
                int remainder = ACount % 3;
                int firstCalc = remainder * 50;
                int secondCalc = ((ACount - remainder)/3)*130;
                int totalA = firstCalc + secondCalc;
                total += totalA;
            }
                    else
                    {
                        total += (ACount * 50);
                    }
            if (BCount >=2)
            {
                int remainder = BCount % 2;
                int firstCalc = remainder * 30;
                int secondCalc = ((BCount - remainder)/2)*45;
                int totalB = firstCalc + secondCalc;
                total += totalB;
            }
                    else
                    {
                    total += (BCount * 30);
                    }

            if (CCount > 0)
            {
                total += (CCount * 70);
            }

            if (DCount > 0)
            {
                total += (DCount * 20);
            }
         


            

        }
    }
}
