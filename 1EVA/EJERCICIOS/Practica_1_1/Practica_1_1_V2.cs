using System;

public class Practica_1_1_V2
{
	public static void Main()
	{
		float numero = 0, solucion = 0;
		char opera;
		bool esNumeroValido = true, esOperacionValida = false;
		do
		{
			do
			{
                try
				{
					Console.Write("Introduce un número: ");
					numero = float.Parse(Console.ReadLine());
                    solucion = numero;
					esNumeroValido = true;
				}	
				catch(Exception)
				{	
					Console.WriteLine("--> Número no valido");
				}

			} while (!esNumeroValido);

            esOperacionValida = false;

            do
            {

               Console.Write("Dame un operador: ");
               opera = Convert.ToChar(Console.ReadLine());

               switch (opera)
               {
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
                                esNumeroValido = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("--> Número no valido");
                            }

                        } while (!esNumeroValido);
                        try
                        {
                            solucion /= numero;  
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("No se puede dividir un número entre 0");
                        }
                        break;

                    case '=':
                        esOperacionValida = true;
                        break;

                    default:
                        Console.WriteLine("Operador no valido");
                        break;
               }        
            } while (!esOperacionValida);

            Console.WriteLine("El resultado es {0}", solucion);

        } while(opera != 's');

	}
}
