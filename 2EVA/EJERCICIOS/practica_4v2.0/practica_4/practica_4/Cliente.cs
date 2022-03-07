using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4
{
    public class Cliente
    {
        private string dniCliente;
        private string nombreCliente;
        private string apellidoCliente;
        private short cuentaCliente;


        public Cliente() { }

        /*- - - - - - - - - - - - - - Getters - - - - - - - - - - - - - -*/

        public string GetDniCliente()
        {
            return dniCliente;
        }

        public string GetNombreCliente()
        {
            return nombreCliente;
        }

        public string GetApellidoCliente()
        {
            return apellidoCliente;
        }

        public short GetCuentaCliente()
        {
            return cuentaCliente;
        }

        /*- - - - - - - - - - - - - - Setters - - - - - - - - - - - - - -*/

        public void SetDniCliente(string dni)
        {
            dniCliente = dni;
        }

        public void SetNombreCliente(string nombre)
        {
            nombreCliente = nombre;
        }

        public void SetApellidoCliente(string apellido)
        {
            apellidoCliente = apellido;
        }

        public void SetCuentaCliente(short cuenta)
        {
            cuentaCliente = cuenta;
        }
    }
}
