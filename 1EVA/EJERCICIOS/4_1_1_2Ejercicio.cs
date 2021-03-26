/* (4.1.1.2) Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
y luego los muestre en el orden contrario al que se introdujeron. */

using System;

class Ejercicio_4_1_1_2 {

    public static void Main(){

        float[] numeros = new float[5];

        Console.WriteLine("¿Sabes lo que me pone? Números reales");
        Console.WriteLine("UFFF dame lo que quiero. Escúpeme 5 números al monitor y calienta esta CPU");

        numeros[0] = Convert.ToSingle(Console.ReadLine());
        numeros[1] = Convert.ToSingle(Console.ReadLine());
        numeros[2] = Convert.ToSingle(Console.ReadLine());
        numeros[3] = Convert.ToSingle(Console.ReadLine());
        numeros[4] = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("¡Eres un guarro! {0} {1} {2} {3} {4}", numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
    }
}