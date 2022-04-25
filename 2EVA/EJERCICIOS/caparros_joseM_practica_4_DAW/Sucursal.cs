using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4
{
    public class Sucursal
    {
        private string codigoSucursal;
        private string ciudadSucursal;
        private string ubicacionSucursal;
        private string cpSucursal;
        
        public Sucursal()
        {
            codigoSucursal = "";
            ciudadSucursal = "Alicante";
            ubicacionSucursal = "Calle del Buen Programador ";
            cpSucursal = "03006";

        }
        /*- - - - - - - - - - - - - - Getters - - - - - - - - - - - - - -*/
        public string GetCodigoSucursal()
        {
            return codigoSucursal;
        }

        public string GetCiudadSucursal()
        {
            return ciudadSucursal;
        }

        public string GetUbicacionSucursal()
        {
            return ubicacionSucursal;
        }

        public string GetCpSucursal()
        {
            return cpSucursal;
        }

        /*- - - - - - - - - - - - - - Setters - - - - - - - - - - - - - -*/

        public void SetCodigoSucursal(string codigo)
        {
            codigoSucursal = codigo;
        }

        public void SetCiudadSucursal(string ciudad)
        {
            ciudadSucursal = ciudad;
        }

        public void SetUbicacionSucursal(string ubicacion)
        {
            ubicacionSucursal = ubicacion;
        }

        public void SetCpSucursal(string cp)
        {
            cpSucursal = cp;
        }

        /*- - - - - - - - - - - - - - Métodos - - - - - - - - - - - - - -*/

        public override string ToString()
        {
            return $"Codigo: {GetCodigoSucursal()}       Ciudad: {GetCiudadSucursal()}       Ubicación: {GetUbicacionSucursal()}         Código postal: {GetCpSucursal()}"; 
        }

    }
}        


   
   
