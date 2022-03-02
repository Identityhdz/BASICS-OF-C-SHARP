using System;

namespace Clasese
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Sale saleOne = new Sale();
            saleOne.Show();



        }

        class Sale {

            DateTime time;


            public Sale() { 
            
            }

            public void Show() {
                Console.WriteLine("Hello this a message froom class Sale");
            }
        
        }
    }
}
