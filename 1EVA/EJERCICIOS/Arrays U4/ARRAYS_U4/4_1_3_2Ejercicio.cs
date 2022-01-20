using System;
    public class Ejercicio_4_1_3_2
    {
        /*(4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a introducir (por ejemplo, 10),
        le pida tods esos números, los guarde en un array y finalmente calcule y muestre la media de esos números.*/

        public static void xxx()
        {
            int num = 0;
            int solucion = 0;
            int suma = 0;
            Console.WriteLine("¿Qué pasa manin? ¿Cuantos numeros quieres?");
            num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];
            Console.WriteLine("Va pues ve dandome que los guardo");

            for(int i = 0; i < num; i++)
            {
                Console.Write("Número: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < num; i++)
            {
                suma += array[i];
            }

            solucion = suma/num;

            Console.WriteLine("Tu media crack: {0}", solucion);

        }
    }

