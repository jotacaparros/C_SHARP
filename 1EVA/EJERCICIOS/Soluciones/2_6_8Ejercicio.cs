using System;
namespace Soluciones
{
    public class Ejercicio_2_6_8
    {
        /*(2.6.8) Crea un programa que devuelva el cambio de una compra, utilizando 
        monedas (o billetes) del mayor valor posible. Supondremos que tenemos una 
        cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay 
        decimales. La ejecución podría ser algo como:
        Precio? 44
        Pagado? 100
        Su cambio es de 56: 50 5 1
        Precio? 1
        Pagado? 100
        Su cambio es de 99: 50 20 20 5 2 2 */
        public static void Main()
        {
            int precio, pago, cambio, billets;
            Console.WriteLine("¿Qué precio?:");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("¿Cuanto paga?");
            pago = Convert.ToInt32(Console.ReadLine());

            cambio = pago - precio;
            billets = cambio;

            Console.Write("Su cambio es de {0}. Aquí tiene: ", cambio);

            while (cambio - 100 >= 0)
            {
                cambio = cambio - 100;
                Console.Write("100 ");
            }

            while (cambio - 50 >= 0)
            {
                cambio = cambio - 50;
                Console.Write("50 ");
            }

            while (cambio - 20 >= 0)
            {
                cambio = cambio - 20;
                Console.Write("20 ");
            }

            while (cambio - 10 >= 0)
            {
                cambio = cambio - 10;
                Console.Write("10 ");
            }

            while (cambio - 5 >= 0)
            {
                cambio = cambio - 5;
                Console.Write("5 ");
            }

            while (cambio - 2 >= 0)
            {
                cambio = cambio - 2;
                Console.Write("2 ");
            }

            while (cambio - 1 >= 0)
            {
                cambio = cambio - 1;
                Console.Write("1 ");
            }
        }   
    }
}
