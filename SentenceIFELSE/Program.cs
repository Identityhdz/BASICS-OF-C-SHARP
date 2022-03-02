using System;

namespace SentenceIFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Condiciones
            bool IHaveHungry = true,
                 IHaceMoney = false;

            if (IHaveHungry && IHaceMoney)
            {
                Console.WriteLine("Buy food");
            }
            else {
                Console.WriteLine("Nothing");
            }

        }
    }
}
