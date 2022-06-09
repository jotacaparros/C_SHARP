using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseM_Caparros_Examen3EVA
{
    public class Distribuidor : Persona
    {
        string email;

        public Distribuidor(string cod, string nom, string telf, string mail) 
        {
            codigo = cod;
            nombre = nom;
            telefono = telf;
            email = mail;
        }

        public string ImprimirDistribuidor()
        {
            return codigo + '#' + nombre + '#' + telefono + '#' + email;
        }
            
    }
}
