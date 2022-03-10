// See https://aka.ms/new-console-template for more information
using System.IO;

string RUTA = "C:\\Users\\mañana\\Desktop\\DAW 1º\\Github\\C_SHARP\\2EVA\\EJERCICIOS\\Ejercicios control de ficheros\\Control Ficheros\\Control Ficheros\\Mover ficheros aqui\\";
Console.WriteLine("Hello, World!");
/*
StreamWriter fichero = File.CreateText("Prueba.txt");

fichero.WriteLine("Hola linea");
fichero.Write("Hola -");
fichero.Write("Adios");

fichero.Close(); */

//StreamReader fichero = new StreamReader ("Prueba.txt");
/*string linea = fichero.ReadLine();
Console.WriteLine("Esto es el contenido: ");
Console.WriteLine(linea);
Console.WriteLine(fichero.ReadLine()); */
//string linea;
/*do
{
  linea = fichero.ReadLine();

    if(linea != null)
        Console.WriteLine(linea);
   
}
while (linea != null); */

//El using determina que parte del fichero se hace o no
/* using (StreamWriter fichero = File.CreateText("Prueba.txt"))
{
    fichero.WriteLine("Hola linea");
    fichero.Write("Hola -");
    fichero.Write("Adios");

} */

/*
string nombreFIchero = RUTA + "prueba2.txt";

StreamWriter fichero2 = new StreamWriter("Prueba2.txt");
fichero2.WriteLine("Primera linea");
fichero2.Close();

fichero2 = File.AppendText("Prueba2.txt");
fichero2.WriteLine("Segunda linea");
fichero2.Close(); */

string nombreFichero = RUTA + "prueba3.txt";

if (File.Exists(nombreFichero))
{
    Console.WriteLine("Sí");
}
else
{
    Console.WriteLine("No");
    StreamWriter fichero3 = new StreamWriter(nombreFichero);
    fichero3.WriteLine("Hola Mundo!");
    fichero3.Close();
}
