using System;

namespace POO
{
    class EjemploClase
    {
        private void xxx()
        {
            PHersona persona1 = new PHersona();
            PHersona persona2 = new PHersona();
            PHersona persona4 = new PHersona(1212212, "Papuchi", 32);

            persona1.SetNombre("Carlos");
            persona1.SetDni(4326783);
            persona1.SetEdad(27);

            persona2.SetNombre("Kobe");
            persona2.SetDni(43223222);
            persona2.SetEdad(34);

            persona1.Mostrar_datos();
            persona2.Mostrar_datos();

            if (persona1.Equals(persona2))
            {
                Console.WriteLine("Sí");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public class PHersona
        {
            private int dni;
            private string nombre;
            private int edad;

            public PHersona(){}
            public PHersona(int dni, string nombre, int edad)
            {
                this.dni = dni;
                this.nombre = nombre;
                this.edad = edad;
            }
            public void Mostrar_datos()
            {
                Console.WriteLine(dni);
                Console.WriteLine(nombre);
                Console.WriteLine(edad);
            }

            public string GetNombre()
            {
                return nombre;
            }

            public void SetNombre(string nombre)
            {
                this.nombre = nombre;
            }

            public int GetDni()
            {
                return dni;
            }

            public void SetDni(int dni)
            {
                this.dni = dni;
            }

            public int GetEdad()
            {
                return edad;
            }

            public void SetEdad(int edad)
            {
                this.edad = edad;
            }

            public bool Equals(PHersona persona)
            {
                if(dni == persona.dni && nombre == persona.nombre && edad == persona.edad)
                {
                    return true;
                }else
                return false;
            }
        }
    }

}
