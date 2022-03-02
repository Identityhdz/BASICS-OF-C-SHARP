using System;

namespace P_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Array as type string
            string[] countries = new string[5] {"MEX", "USA", "ARG", "JP", null };

            

            for (int i = 0; i < countries.Length; i++)
            {
                
                if (countries[i] == null)
                {
                    Console.WriteLine("Vacio");
                }
                else {
                    Console.WriteLine(countries[i]);
                }
            }

        }
    }
}
