using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase07
{
    class Conclave
    {
        private int _cantMaxCardenales;
        private List<Cardenal> _cardenales;
        private bool _habemusPapa;
        private string _lugarEleccion;
        private Cardenal _papa;
        public static int cantidadVotaciones;
        public static DateTime fechaVotacion;
        
        static Conclave()
        {
            cantidadVotaciones = 0;
            fechaVotacion = DateTime.Today;         
        }

        public Conclave()
        {
            this._cantMaxCardenales = 1;
            this._lugarEleccion = "Capilla Sixtina";
            this._cardenales = new List<Cardenal>();
        }

        private Conclave(int cantidadCardenales):this()
        {
            this._cantMaxCardenales = cantidadCardenales;
        }

        public Conclave(int cantidadCardenales, string lugarEleccion)
            :this(cantidadCardenales)
        {
            this._lugarEleccion = lugarEleccion;
        }

        public static implicit operator Conclave(int cantidadCardenales)
        {
            return new Conclave(cantidadCardenales);
        }

        //public static explicit operator bool(Conclave con)
        //{

        //}

        private bool HayLugar()
        {
            bool hayLugar = false;

            if (this._cardenales.Count < this._cantMaxCardenales)
            {
                hayLugar = true;
            }

            return hayLugar;
        }

        private string MostrarCardenales()
        {

            foreach (Cardenal item in _cardenales)
            {
                return Cardenal.Mostrar(item);
            }

            return "";
        }

        public string Mostrar()
        {
            if (this._habemusPapa==true)
            {
                return "HABEMUS PAPA " + _papa.ObtenerNombreYNombrePapal();
            }

            else
            {
                return "Lugar de la elección: " + this._lugarEleccion + "\nFecha: " + fechaVotacion.ToShortDateString() +
                "\nCantidad de votaciones: " + cantidadVotaciones + "\n" + MostrarCardenales() + "NO HABEMUS PAPA!!!!";
            }
            
        }

        public static bool operator ==(Conclave con, Cardenal c)
        {
            bool comparar = false;

            foreach (Cardenal item in con._cardenales)
            {
                if (item==c)
                {
                    comparar = true;
                }
            }

            return comparar;
        }

        public static bool operator !=(Conclave con, Cardenal c)
        {
            return !(con == c);
        }

        public static Conclave operator +(Conclave con, Cardenal c)
        {

            con._cardenales.Add(c);

            return con;
        }

    }
}
