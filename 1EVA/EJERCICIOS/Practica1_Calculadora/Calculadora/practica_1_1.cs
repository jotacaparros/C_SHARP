// --------------------------------------------
// José Manuel Caparrós Ivorra
// Curso DAW/DAM
// Modalidad Presencial
// Práctica nº 1
// --------------------------------------------
using System;

namespace Calculadora
{
    class practica_1_1
    {
        static void Main(string[] args)
        {
            int numA, numB; /*solucion*/
            char opera;

            Console.WriteLine("CALCULADORA");

            do
            {
                
                Console.WriteLine("INTRODUCE UN NÚMERO:");
                numA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("INTRODUCE UN NÚMERO:");
                numB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());

                switch (opera)
                {
                    case '=': Console.Write(numA);
                        break;
                    case '+': numA = numA + numB;
                        break;
                    case '-': numA = numA - numB;
                        break;
                    case '/': numA = numA / numB;
                        break;
                    case '*': numA = numA * numB;
                        break;
                    default: Console.WriteLine("INTRODUCE UN CARÁCTER VALIDO");
                        break;
                }



            }
            while(numA != 's'|| numB != 's'|| opera != 's' /*opera2 != 's'*/);

            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
