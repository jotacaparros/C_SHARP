using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4
{
    public class Cuenta
    {
        private string codigoCuenta;
        private int dineroCuenta;
        private Cliente cliente;
        private Sucursal sucursal;
        private string iban;

        public Cuenta(string codigoCuenta, Cliente cliente, Sucursal sucursal) {
            
            this.cliente = cliente;
            this.codigoCuenta = codigoCuenta;
            dineroCuenta = 0;
            this.sucursal = sucursal;
        }

        /*- - - - - - - - - - - - - - Getters - - - - - - - - - - - - - -*/

        public string GetCodigoCuenta()
        {
            return codigoCuenta;
        }

        public int GetDineroCuenta()
        {
            return dineroCuenta;
        }

        public Cliente GetClienteCuenta()
        {
            return cliente;
        }

        public Sucursal GetSucursalCuenta()
        {
            return sucursal;
        }

        public string GetIbanCuenta()
        {
            return iban;
        }
        /*- - - - - - - - - - - - - - Setters - - - - - - - - - - - - - -*/

        public void SetCodigoCuenta(string codigo)
        {
            codigoCuenta = codigo;
        }

        public void SetDineroCuenta(int dinero)
        {
            dineroCuenta = dinero;
        }

        public void SetClienteCuenta(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void SetSucursalCuenta(Sucursal sucursal)
        {
            this.sucursal = sucursal;
        }

        public void SetIbanCuenta(string iban)
        {
            this.iban = iban;
        }
        /*- - - - - - - - - - - - - - Métodos - - - - - - - - - - - - - -*/

        public override string ToString()
        {
            return $"Sucursal: {GetSucursalCuenta().GetCodigoSucursal()}       Dueño: {GetClienteCuenta().GetNombreCliente()} {GetClienteCuenta().GetApellidoCliente()}       Código cuenta: {GetCodigoCuenta()}         Saldo disponible: {GetDineroCuenta()}";
           
           

        }

    }
}
