using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4
{
    public class Cuenta
    {
        private short codigoCuenta;
        private int dineroCuenta;

        public Cuenta() { }

        /*- - - - - - - - - - - - - - Getters - - - - - - - - - - - - - -*/

        public short GetCodigoCuenta()
        {
            return codigoCuenta;
        }

        public int GetDineroCuenta()
        {
            return dineroCuenta;
        }

        /*- - - - - - - - - - - - - - Setters - - - - - - - - - - - - - -*/

        public void SetCodigoCuenta(short codigo)
        {
            codigoCuenta = codigo;
        }

        public void SetDineroCuenta(int dinero)
        {
            dineroCuenta = dinero;
        }
    }
}
