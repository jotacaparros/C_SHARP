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
            int numA, numB = 0, solucion = 0;
            char opera;

            Console.WriteLine("CALCULADORA");

            do
            {
                numero:
                Console.WriteLine("INTRODUCE UN NÚMERO:");
                numA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());
                    if (opera == '=')
                    {
                        goto operacion;
                    }

                Console.WriteLine("INTRODUCE UN NÚMERO:");
                numB = Convert.ToInt32(Console.ReadLine());

            operacion:
                switch (opera)
                {
                    case '=':
                        Console.WriteLine(solucion);
                        goto numero;
                    case '+':
                        solucion = solucion + (numA + numB);
                        break;
                    case '-':
                        solucion = solucion - (numA - numB);
                        break;
                    case '/':
                        solucion = solucion / (numA / numB);
                        break;
                    case '*':
                        solucion = solucion * (numA * numB);
                        break;
                    default:
                        Console.WriteLine("INTRODUCE UN CARÁCTER VALIDO");
                        break;

                }
                

                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());
                    if(opera=='=')
                    {
                        goto operacion;
                    }

              
            }
            while (numA != 's' || /* numB != 's' ||*/ opera != 's' /*opera2 != 's'*/);

            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
