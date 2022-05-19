using System;
using System.IO;

namespace ejercicio_8_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ficheroEscritura = new StreamWriter("calculadora.txt", true);
            bool fin = false;
            bool cto = false;
            int numero1 = 0;
            int numero2 = 0;
            string operacion;
            string continuar;

            while (!fin)
            {
                cto = false;
                do
                {
                    try
                    {
                        Console.Write("Número 1:");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        cto = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (!cto);

                cto = false;
                do
                {
                    try
                    {
                        Console.Write("Número 2:");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        cto = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (!cto);


                cto = false;
                do
                {
                    Console.Write("Operación:");
                    operacion = Console.ReadLine();

                    if ((operacion == "+") || (operacion == "-") ||
                        (operacion == "*") || (operacion == "/"))
                        cto = true;
                    else
                        Console.WriteLine("Operación incorrecta");
                } while (!cto);

                switch (operacion)
                {
                    case "+":
                        ficheroEscritura.WriteLine(Convert.ToString(numero1) + " + " +
                                                   Convert.ToString(numero2) + " = " +
                                                   Convert.ToString(numero1 + numero2));
                        break;
                    case "-":
                        ficheroEscritura.WriteLine(Convert.ToString(numero1) + " - " +
                                                   Convert.ToString(numero2) + " = " +
                                                   Convert.ToString(numero1 - numero2));
                        break;
                    case "*":
                        ficheroEscritura.WriteLine(Convert.ToString(numero1) + " * " +
                                                   Convert.ToString(numero2) + " = " +
                                                   Convert.ToString(numero1 * numero2));
                        break;
                    case "/":
                        if (numero2 != 0)
                            ficheroEscritura.WriteLine(Convert.ToString(numero1) + " / " +
                                                       Convert.ToString(numero2) + " = " +
                                                       Convert.ToString(numero1 / numero2));
                        else
                            ficheroEscritura.WriteLine(Convert.ToString(numero1) + " / " +
                                                       Convert.ToString(numero2) + " = " +
                                                       "Indeterminado");
                        break;
                }

                Console.Write("¿Otra operación (s/n)?");
                continuar = Console.ReadLine().ToUpper();

                fin = (continuar=="N");
            }

            ficheroEscritura.Close();
        }
    }
}
