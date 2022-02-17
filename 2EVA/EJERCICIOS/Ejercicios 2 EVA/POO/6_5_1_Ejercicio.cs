using System;
/*(6.5.1) Crea un proyecto a partir del ejemplo 06.05a, en el que cada clase 
 esté en un fichero separado.Como podrás comprobar, ahora necesitarás un 
 "using System" en cada fuente.
 */
public class Ejercicio_6_5_1
{
	public Ejercicio_6_5_1()
	{
			Puerta p = new Puerta();
			Console.WriteLine("Valores iniciales...");
			p.MostrarEstado(); Console.WriteLine();
			Console.WriteLine("Vamos a abrir...");
			p.Abrir(); p.SetAncho(80);
			p.MostrarEstado();
			Console.WriteLine();
			Console.WriteLine("Ahora el portón...");


		}
	}
