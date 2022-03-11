using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale saleOne = new Sale(1, DateTime.Now);
            saleOne.Show();
            saleOne.Total = 1;
            //saleOne.Time = DateTime.Now; // No se puede modificar valor, es de solo lectura
            Console.WriteLine(saleOne.Total);
        }

        class Sale
        {
            // Properties
            private int total;
            private DateTime time;


            //public string Time {
            //    get {
            //        return time.ToLongDateString();
            //    }
            //}


            // Accesors 1 -> Acceder a las propiedades de la clase
            public int Total
            {
                // Obtener datos, solo lectura
                get
                {
                    return total;
                }

                // Editar valor
                set
                {
                    if (value < 0)
                        value = 0;
                    total = value;

                }
            }

            //Accesors 2 -> Aceder a la propiedad de clase total como string
            public string Total2
            {
                get
                {
                    return total.ToString("#.00");
                }
            }


            // Buider of class Sale
            public Sale(int total, DateTime time)
            {
                this.total = total;
                this.time = time;
            }

            // Metod One of class Sale
            public void Show()
            {
                Console.WriteLine("Hello this a message froom class Sale");
            }
        }
    }
}
