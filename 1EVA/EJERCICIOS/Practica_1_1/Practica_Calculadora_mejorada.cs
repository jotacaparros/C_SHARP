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

		float numero, solucion = 0;
        string operacion = " ";
        int posicion = 0, posicionA = 0, posicionD = 0, primerNum, segundoNum;

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
              
                try
				{
					Console.Write("Introduce un número: ");
					numero = float.Parse(Console.ReadLine());
                    operacion = operacion.Insert(operacion.Length - 1, numero.ToString());

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
               
               Console.Write("Introduce un operación: ");
               opera = Convert.ToChar(Console.ReadLine());
  
               switch (opera)
               {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        operacion = operacion.Insert(operacion.Length - 1, opera.ToString());
                        do
                        {
                            try
                            {
                                Console.Write("Introduce un número: ");
                                numero = float.Parse(Console.ReadLine());
                                solucion = numero;
                                operacion = operacion.Insert(operacion.Length - 1, numero.ToString());


                                esNumeroValido = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                                esNumeroValido = false;
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

            for (int i = 0; i < operacion.Length - 1; i++)
            {
                if(operacion[i] == '*')
                {
                    for (int j = posicion - 1; j >= 0; j--)
                    {
                        try
                        {
                            int.Parse(operacion[j].ToString());
                        }
                        catch
                        {
                            posicionA = j + 1;
                        }
                    }
                    primerNum = int.Parse(operacion.Substring(posicionA, posicion));
                    for (int j = posicion - 1; j >= 0; j++)
                    {
                        try
                        {
                            int.Parse(operacion[j].ToString());
                        }
                        catch
                        {
                            posicionD = j + 1;
                        }
                    segundoNum = int.Parse(operacion.Substring(posicionD, posicion));


                            
                    }
                }

            }
          /*  if(operacion.Contains("*")||operacion.Contains("/"))
            {

                posicion = operacion.IndexOf("*", posicion);
                for (int i = posicion - 1; i >= 0; i--)
                {
                    try
                    {
                        int.Parse(operacion[i].ToString());
                    }
                    catch
                    {
                        posicionA = i + 1;
                    }   
                }
                primerNum = int.Parse(operacion.Substring(posicionA, posicion));

            }*/
            Console.WriteLine(operacion);
            Console.WriteLine("El resultado es {0}", solucion);
            Console.WriteLine();

        } while(opera != 's');
        Console.WriteLine("FIN DEL PROGRAMA");
	}
}
