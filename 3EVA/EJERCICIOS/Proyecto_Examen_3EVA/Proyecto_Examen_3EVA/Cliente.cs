using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseM_Caparros_Examen3EVA
{
     public class Cliente : Persona
    {
        string apellido;
        string direccion;
        private List<string> codigos;

        public Cliente(string cod, string nom, string ape, string telf, string dire)
        {
            codigo = CodigoRandom(4, ref codigos);
            nombre = nom;
            apellido = ape;
            telefono = telf;
            direccion = dire;
        }

        private string CodigoRandom(int num, ref List<string> codigos)
        {
            Random random = new Random();
            string aleatorio;

            do
            {
                aleatorio = random.Next(0, 10000).ToString();
                while (aleatorio.Length < num)
                {
                    aleatorio = "0" + aleatorio;
                }

            } while (codigos.Contains(aleatorio));
            
               
            codigos.Add(aleatorio);
            

            return aleatorio;
        }
        public string ImprimirCliente()
        {
            return codigo + '#' + nombre + '#' + apellido + '#' + telefono + '#' + direccion;
        }
    }
}
