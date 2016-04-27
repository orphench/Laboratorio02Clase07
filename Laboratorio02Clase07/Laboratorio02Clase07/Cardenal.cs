using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase07
{
    class Cardenal
    {
        private int _cantVotosRecibidos;
        private ENacionalidades _nacionalidad;
        private string _nombre;
        private string _nombrePapal;

        private Cardenal()
        {
            this._cantVotosRecibidos = 0;
        }

        public Cardenal(string nombre, string nombrePapal):this()
        {
            this._nombre = nombre;
            this._nombrePapal = nombrePapal;
        }

        public Cardenal(string nombre, string nombrePapal, ENacionalidades nacionalidad)
            : this(nombre, nombrePapal)
        {
            this._nacionalidad = nacionalidad;
        }

        public int getCantidadVotosRecibidos()
        {
            return this._cantVotosRecibidos;
        }

        public string ObtenerNombreYNombrePapal()
        {
            //string nombreFinal = _nombrePapal + 

            return "El cardenal " + this._nombre + " se llamará Papa " + this._nombrePapal;
        }

        private string Mostrar()
        {
            return ObtenerNombreYNombrePapal() + "\nNacionalidad: "+this._nacionalidad+"\nVotos recibidos: "+_cantVotosRecibidos;
        }
    }
}
