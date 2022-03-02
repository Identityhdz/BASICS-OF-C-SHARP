using System;

namespace P_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 1;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Opcion 1");
                    break;

                case 2:
                    Console.WriteLine("Opcion 2");
                    break;

                default:
                    Console.WriteLine("Opcion por defecto");
                    break;
            }
        }
    }
}
