 // Crea un programa que convierta millas a metros 1 milla = 1609 metros
 
 
 class Ejercicio_1_9_1 {

     static void Main() {

        int milla = 0;
        
        System.Console.WriteLine("Introduce las millas que quieres pasar a metros: ");
        
        milla = System.Convert.ToInt32(System.Console.ReadLine());

        int metros = milla * 1609;
        
        System.Console.WriteLine("{0} millas es igual a {1} metros", milla, metros);

     }
 }