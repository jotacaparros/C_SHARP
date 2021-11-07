// --------------------------------------------
// José Manuel Caparrós Ivorra
// Curso DAW/DAM 
// Modalidad Presencial
// Práctica nº 1
// --------------------------------------------
using System;
public class Practica_1_1_V2
{
	public static void Main()
	{
//Declaro 2 variables. Una para el número que introducirá el usuario y otra que haga de contendor de las operaciones.

		float numero = 0, solucion = 0;

//Otra para que el usuario introduzca un operador		
     
        char opera;
//Y dos más que utilizaré para romper mis bucles do while.
//Me podría ahorrar una variable, pero me parece más ordenado saber que booleano rompe qué tipo de bucle y para tener controlado el valor.
		
        bool esNumeroValido = true, esOperacionValida = true;
		
//Entro en un bucle para que el programa se repita hasta que el usuario introduzca 's'.        
        do
		{
//Dentro de este, añado dos bucles más, uno para el primer número que introduzca el usuario
//Y otro para el operador.
			do
			{
                //Este es el bucle donde declara el usuario el primer número.
                //Y en el declaro un trycatch para asegurarme de que no me meta cualquier mierda que no sea un número.
                try
				{
					Console.Write("Introduce un número: ");
					numero = float.Parse(Console.ReadLine());
                    solucion = numero;

                //Aquí uso el booleano para romper el bucle.

					esNumeroValido = true;
				}	
				catch(Exception)
				{	
					Console.WriteLine("--> Número no valido");
                    esNumeroValido = false;
                }

			} while (!esNumeroValido);
             
           //Aquí hago un control del valor de la variable para entrar en el bucle del operador
          
            esOperacionValida = false;

            do
            {
               //Este es el bucle donde el usuario introduce el operador.
               Console.Write("Introduce un operación: ");
               opera = Convert.ToChar(Console.ReadLine());

               //Para poder realizar operaciones le metemos un switch

               switch (opera)
               {
                    //En cada caso metemos el bucle de pedir un número para poder encadenar operaciones.
                    case '+':
                        do
                        {
                            try
                            {
                                Console.Write("Introduce un número: ");
                                numero = float.Parse(Console.ReadLine());
                                esNumeroValido = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                            }

                        } while (!esNumeroValido);
                        solucion += numero;
                        break;

                    case '-':
                        do
                        {
                            try
                            {
                                Console.Write("Introduce un número: ");
                                numero = float.Parse(Console.ReadLine());
                                esNumeroValido = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                            }

                        } while (!esNumeroValido);
                        solucion -= numero;
                        break;

                    case '*':
                        do
                        {
                            try
                            {
                                Console.Write("Introduce un número: ");
                                numero = float.Parse(Console.ReadLine());
                                esNumeroValido = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                            }

                        } while (!esNumeroValido);
                        solucion *= numero;
                        break;

                    case '/':
                        do
                        {
                            try
                            {
                                Console.Write("Introduce un número: ");
                                numero = float.Parse(Console.ReadLine());
                                if (numero != 0)
                                {
                                    solucion /= numero;
                                    esNumeroValido = true;
                                }
                                else
                                {
                                    Console.WriteLine("No se puede dividir un número entre 0");
                                    esNumeroValido = false;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                            }

                        } while (!esNumeroValido);
                        break;

                    case '=':
                        esOperacionValida = true;
                        break;

                    case 's':
                        esOperacionValida = true;
                        break;

                    default:
                        Console.WriteLine("--> Operación incorrecta");
                        break;
               }        
            } while (!esOperacionValida);

            Console.WriteLine("El resultado es {0}", solucion);
            Console.WriteLine();

        } while(opera != 's');
        Console.WriteLine("FIN DEL PROGRAMA");
	}
}
