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
            char opera = 'n', salida, random;

            Console.WriteLine("CALCULADORA");
         
                do
                {
                    try
                    {
                    numero:
                        Console.Write("INTRODUCE UN NÚMERO: ");
                        numA = Convert.ToInt32(Console.ReadLine());

                    otra:
                        Console.Write("INTRODUCE UNA OPERACIÓN: ");
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
                    otroNumero:
                        Console.Write("INTRODUCE UN NÚMERO: ");
                        numB = Convert.ToInt32(Console.ReadLine());

                    operacion:
                        switch (opera)
                        {
                            case '=':
                                Console.WriteLine("El resultado es {0}", solucion);
                                Console.WriteLine();
                                goto numero;
                            case '+':
                                solucion = (numA + numB);
                                break;
                            case '-':
                                solucion = (numA - numB);
                                break;
                            case '/':
                            if (numA == 0 || numB == 0)
                            {
                                Console.WriteLine("No se puede dividir entre 0");
                                goto otroNumero;
                               
                            }   else
                                {
                                    solucion = (numA / numB);
                                }
                                break;
                            case '*':
                                solucion = (numA * numB);
                                break;
                            case 's':
                                Console.WriteLine("El resultado es {0}", solucion);
                                goto final;
                            default:
                                Console.WriteLine("--> Operación incorrecta");
                                goto otra;
                        } 

                    operacion2:
                        Console.Write("INTRODUCE UNA OPERACIÓN: ");
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
                            else
                            {
                                Console.Write("INTRODUCE UN NÚMERO: ");
                                numC = Convert.ToInt32(Console.ReadLine());
                                switch (opera)
                                {
                                    case '=':
                                        Console.WriteLine("El resultado es {0}", solucion);
                                        Console.WriteLine();
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
                                    case 's':
                                        Console.WriteLine("El resultado es {0}", solucion);
                                        goto final;
                                    default:
                                        Console.WriteLine("--> Operación incorrecta");
                                        break;

                                }
                            }
                            goto operacion2;
                        }
                    final:
                        random = 'n';
                    }   catch(FormatException)
                        {
                        Console.WriteLine("--> Número incorrecto");
                        }

                }while (opera != 's');
              
             
            Console.WriteLine("FIN DEL PROGRAMA");
        }
    }
}
