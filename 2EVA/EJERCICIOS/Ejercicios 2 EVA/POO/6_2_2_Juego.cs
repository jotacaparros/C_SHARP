using System;
/*(6.2.2) Tras leer la descripción de Space Invaders que vimos en el apartado anterior,
 crea una clase Juego,que sólo contenga un método Lanzar, void, sin parámetros, 
 que escriba en pantalla "Bienvenido a Console Invaders. Pulse Intro para salir"
 y se parará hasta que el usuario pulse Intro. Prepara también un Main (en la misma clase),
 que cree un objeto de la clase Juego y lo lance.*/
public class PruebaJuego
{
	public void Lanzar()
	{
        bool salir = false;
        char pulsar;
        Console.WriteLine("Bienvenido a Console Invanders. Pulse Intro para salir");
        do
        {
            pulsar = Convert.ToChar(Console.ReadLine());
            
            if(pulsar != null)
            {
                salir = false;
            
            }else
            {
                salir = true;
            }
           
        } while (salir != true);
	}
}
