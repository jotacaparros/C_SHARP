
/*5.2.1 Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 25 líneas 
en blanco. Crea también un "Main" que permita probarla.*/

using System;

public class Ejercicio5_2_1 {

    static void Main(){

        Console.WriteLine("Colega escribe algo");
        Console.ReadLine();

        BorrarPantalla();


    }

    static void BorrarPantalla() {

        Console.WriteLine("                                 ");

    }
   
}