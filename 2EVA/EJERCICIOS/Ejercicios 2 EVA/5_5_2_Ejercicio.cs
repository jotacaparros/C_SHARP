using System;
namespace Ejercicios_2_EVA
{
    public class Ejercicio_5_5_2
    {
        /*(5.5.2) Crea una función "EscribirTablaMultiplicar", 
         que reciba como parámetro un número entero, y escriba 
         la tabla de multiplicar de ese número (por ejemplo, 
         para el 3 deberá llegar desde "3x0=0" hasta "3x10=30").*/

        public static void xxx()
        {
            Console.WriteLine("Numero:");
            int numero = Convert.ToInt32(Console.ReadLine());
            EscribirTablaMultiplicar(numero);
        }
        public static void EscribirTablaMultiplicar(int x)
        {
            for (int i = 0; i < 11; i++)
            {
                int resultado = x * i;
                Console.WriteLine("{0} * {1} = {2}", x, i, resultado);
               
            }
        }
    }
}
