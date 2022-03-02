using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i  < 5)
            {
                Console.WriteLine("Contador " + i);
                i++;
            }


            int j = 0;

            while (j < 10)
            {
                if (j > 5)
                    break;
                Console.WriteLine("Contador j" + j);
                j++;
            }
            
        }
    }
}
