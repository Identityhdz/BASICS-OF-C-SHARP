using System;

namespace Clasese
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale saleOne = new Sale(1, DateTime.Now);
            saleOne.Show();
        }

        class Sale {

            // Properties
            int total;
            DateTime time;

            // Buider of class Sale
            public Sale(int total, DateTime time) {
                this.total = total;
                this.time = time;
            }

            // Metod One of class Sale
            public void Show() {
                Console.WriteLine("Hello this a message froom class Sale");
            }
        
        }
    }
}
