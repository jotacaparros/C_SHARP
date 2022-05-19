using System;
using System.IO;

namespace ejercicio_8_3_4
{
    class Program
    {
        struct tipoFicha
        {
            public string nombreFich;
            public long tamanyo;
        }

        static tipoFicha[] fichas = new tipoFicha[1000];
        static int numeroFichas = 0;

        public static void Main(string[] args)
        {
            int opcion;

            CargarDatos();

            do
            {
                switch (opcion = Menu())
                {
                    case 1: Anadir(); break;
                    case 2: MostrarTodo(); break;
                    case 3: MostrarEncimaDe(); break;
                    case 4: Ver(); break;
                    case 5: Console.WriteLine("Fin del programa"); break;
                    default: Console.WriteLine("Opción desconocida!"); break;
                }
            } while (opcion != 5);

            Guardar();
        }

        public static void CargarDatos()
        {
            StreamReader fichero;
            string nombreFich = "";
            string tamanyo = "";

            try
            {
                using (fichero = new StreamReader("basedatos.txt"))
                {
                    nombreFich = fichero.ReadLine();
                    tamanyo = fichero.ReadLine();

                    while (nombreFich != null)
                    {
                        fichas[numeroFichas].nombreFich = nombreFich;
                        fichas[numeroFichas].tamanyo = Convert.ToInt32(tamanyo);

                        numeroFichas++;

                        nombreFich = fichero.ReadLine();
                        tamanyo = fichero.ReadLine();
                    }

                }
            }
            catch (Exception e)
            {
            }
        }

        public static void Guardar()
        {
            StreamWriter fichero;

            using (fichero = new StreamWriter("basedatos.txt"))
            {
                for (int i = 0; i < numeroFichas; i++)
                {
                    fichero.WriteLine("{0}", fichas[i].nombreFich);
                    fichero.WriteLine("{0}", fichas[i].tamanyo);
                }
            }
        }

        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1.- Añadir datos de un nuevo fichero");
            Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
            Console.WriteLine("4.- Ver datos de un fichero");
            Console.WriteLine("5.- Salir");
            Console.WriteLine();
            Console.Write("Opcion: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Anadir()
        {
            if (numeroFichas < 1000)
            {
                Console.Write("Introduce el nombre del fichero: ");
                fichas[numeroFichas].nombreFich = Console.ReadLine();

                Console.Write("Introduce el tamaño en KB: ");
                fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());

                numeroFichas++;
            }
            else
                Console.WriteLine("Máximo de fichas alcanzado (1000)");
        }

        public static void MostrarTodo()
        {
            for (int i = 0; i < numeroFichas; i++)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);

            Console.WriteLine("\n\nPulsa intro para continuar");
            Console.ReadLine();
        }

        public static void MostrarEncimaDe()
        {
            int tamanyoBuscar;

            Console.Write("¿A partir de que tamaño quieres ver? ");
            tamanyoBuscar = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroFichas; i++)
                if (fichas[i].tamanyo >= tamanyoBuscar)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);

            Console.WriteLine("\n\nPulsa intro para continuar");
            Console.ReadLine();
        }

        public static void Ver()
        {
            string nomnbreFich;

            Console.Write("¿Fichero a ver todos sus datos? ");
            nomnbreFich = Console.ReadLine();

            for (int i = 0; i < numeroFichas; i++)
                if (fichas[i].nombreFich == nomnbreFich)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);

            Console.WriteLine("\n\nPulsa intro para continuar");
            Console.ReadLine();
        }

    }
}
