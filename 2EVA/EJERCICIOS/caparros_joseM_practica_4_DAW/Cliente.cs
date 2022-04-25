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
        private Cuenta cuenta;

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

        public Cuenta GetCuentaCliente()
        {
            return cuenta;
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
        
        public void SetCuentaCliente(Cuenta cuenta)
        {
            this.cuenta = cuenta;
        }

        /*- - - - - - - - - - - - - - Métodos - - - - - - - - - - - - - -*/

        public override string ToString()
        {
        //Aquí va un if para saber si imprimimos mensaje con o sin IBAN    
           if (GetCuentaCliente().GetIbanCuenta() =="" || GetCuentaCliente().GetIbanCuenta() == null)
               {
                return $"DNI: {GetDniCliente()}       Nombre: {GetNombreCliente()}       Apellido: {GetApellidoCliente()}         Código cuenta: {GetCuentaCliente().GetCodigoCuenta()}";
            }
               else
               {
                return $"DNI: {GetDniCliente()}       Nombre: {GetNombreCliente()}       Apellido: {GetApellidoCliente()}         Código cuenta: {GetCuentaCliente().GetCodigoCuenta()}         IBAN: {GetCuentaCliente().GetIbanCuenta()}";
               }
        }
    }
}
