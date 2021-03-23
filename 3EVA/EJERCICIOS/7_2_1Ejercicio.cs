// (7.2.1) Crea un programa que pida al usuario 5 números enteros y luego los muestre en orden contrario, utilizando una pila.

using System;
using System.Collections;

namespace Ejercicio721
{
class Ejercicio_7_2_1
{
    static void Main(string[] args){

        Stack myNumbers = new Stack();

        Console.Write("Dame números padre. Cuando te canses pulsa intro: ");
           
        for (int i = 0; i < 5; i++)   
            myNumbers.Push(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Padre me diseñaste para esto:");
        while (myNumbers.Count > 0)
            Console.WriteLine(myNumbers.Pop());
        
    }
}
}