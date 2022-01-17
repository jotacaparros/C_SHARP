using System;

public class ModulacionCalculadora
{
   static int resultado = 0;
   static int numero = 0;
   static char operacion = ' ';
   static bool incorrecto = true, incorrecta = true;
    public static void funciona(string[] args)
	{
        do
        {
            do
            {
                IntroducirNumero();
                incorrecto = true;
                
                RealizarOperacion();
                
                ComprobarOperacion();
                incorrecta = true;

            } while (operacion != '=' && operacion != 's');

            Console.WriteLine("El resultado es {0}\n", resultado);
            if (operacion != 's')
                operacion = ' ';
        } while (operacion != 's');

    }

	public static void IntroducirNumero()
    {
        do
        {
            try
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                incorrecto = false;
            }
            catch (Exception)
            {
                Console.WriteLine("--> Número incorrecto");
            }
        } while (incorrecto);
    }
    public static void ComprobarOperacion()
    {
        do
        {
            try
            {
                Console.Write("Introduce una operación: ");
                operacion = Convert.ToChar(Console.ReadLine());

                switch (operacion)
                {
                    case '+': case '-': case '/': case '*': case '=': case 's': incorrecta = false; break;
                    default: throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("--> Operación incorrecta");
            }
        } while (incorrecta);
    }
    public static void RealizarOperacion()
    {
        if (operacion != ' ')
        {
            switch (operacion)
            {
                case '+': resultado += numero; break;
                case '-': resultado -= numero; break;
                case '/':
                    try
                    {
                        resultado /= numero;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("--> No se puede dividir entre 0");
                    }
                    break;
                case '*': resultado *= numero; break;
            }
        }
        else
        {
            resultado = numero;
        }
    }

}
