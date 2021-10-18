/* (4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un array), 
calcule su media aritmética y después muestre en pantalla la media y los datos tecleados. */

using System;

class Ejercicio_4_1_1_1 {

    public static void Main() {

        int[] numeros = new int[4];
        float media;
       
        Console.WriteLine("¿Sabes lo que me pone? Números enteros y calcular la media");
        Console.WriteLine("UFFF dame lo que quiero. Escúpeme 4 números al monitor y calienta esta CPU");

        numeros[0] = Convert.ToInt32(Console.ReadLine());
        numeros[1] = Convert.ToInt32(Console.ReadLine());
        numeros[2] = Convert.ToInt32(Console.ReadLine());
        numeros[3] = Convert.ToInt32(Console.ReadLine());

        media = Convert.ToSingle((numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4);

        
        Console.WriteLine("¡Eres un guarro! {0} {1} {2} {3}", numeros[0], numeros[1], numeros[2], numeros[3]);
        Console.WriteLine("OH SÍ LA media de esos datos es {0}", media);
    }

}