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
            int numA, numB = 0, numC = 0, solucion = 0;
            char opera, salida;

            Console.WriteLine("CALCULADORA");

            do
            {
                numero:    
                Console.WriteLine("INTRODUCE UN NÚMERO:");
                numA = Convert.ToInt32(Console.ReadLine());

                otra:
                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());
                if (opera == '=')
                {
                    goto operacion;
                }
                    else
                    {
                        if ((opera != '+') && (opera != '-') && (opera != '*') && (opera != '/'))
                        {
                            goto operacion;
                        }
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
                        solucion = (numA + numB);
                        break;
                    case '-':
                        solucion = (numA - numB);
                        break;
                    case '/':
                        solucion = (numA / numB);
                        break;
                    case '*':
                        solucion = (numA * numB);
                        break;
                    default:
                        Console.WriteLine("INTRODUCE UN CARÁCTER VALIDO");
                        goto otra;
                        break;

                }
                
                operacion2:
                Console.WriteLine("INTRODUCE UNA OPERACIÓN:");
                opera = Convert.ToChar(Console.ReadLine());
                    if(opera=='=')
                    {
                        goto operacion;
                    }
                    else 
                    {
                        if ((opera != '+') && (opera != '-') && (opera != '*') && (opera != '/'))
                        {
                        goto operacion;
                        }
                            else
                            {
                                Console.WriteLine("INTRODUCE UN NÚMERO:");
                                numC = Convert.ToInt32(Console.ReadLine());
                                switch (opera)
                                {
                                    case '=':
                                        Console.Write(solucion);
                                        goto numero;
                                    case '+':
                                        solucion = solucion + numC;
                                        break;
                                    case '-':
                                        solucion = solucion - numC;
                                        break;
                                    case '/':
                                        solucion = solucion / numC;
                                        break;
                                    case '*':
                                        solucion = solucion * numC;
                                        break;
                                    default:
                                        Console.WriteLine("INTRODUCE UN CARÁCTER VALIDO");
                                        break;

                                }
                            }                  
                        goto operacion2;
                    }
                

              
            }
            while (salida != 's');

            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
