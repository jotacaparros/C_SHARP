using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_4
{
    public class Sucursal
    {
        private short codigoSucursal;
        private string ciudadSucursal;
        private string ubicacionSucursal;
        private int cpSucursal;
        
        public Sucursal()
        {   
        } 

        /*- - - - - - - - - - - - - - Getters - - - - - - - - - - - - - -*/
        public short GetCodigoSucursal()
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

        public int GetCpSucursal()
        {
            return cpSucursal;
        }

        /*- - - - - - - - - - - - - - Setters - - - - - - - - - - - - - -*/

        public void SetCodigoSucursal(short codigo)
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

        public void SetCpSucursal(int cp)
        {
            cpSucursal = cp;
        }
    }
}        


   
   
