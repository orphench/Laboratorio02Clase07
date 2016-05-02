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

        public static string Mostrar(Cardenal c)
        {
            //Console.WriteLine("CARDENALES:");
            return c.Mostrar();
        }

        private string Mostrar()
        {
            return ObtenerNombreYNombrePapal() + "\nNacionalidad: "+this._nacionalidad+"\nVotos recibidos: "+_cantVotosRecibidos;
        }

        public string ObtenerNombreYNombrePapal()
        {
            return "\nEl cardenal " + this._nombre + " se llamará \"Papa " + this._nombrePapal+ "\"";
        }

        public static bool operator ==(Cardenal c1, Cardenal c2)
        {
            bool comparar = false;

            if (c1._nombre == c2._nombre && c1._nombrePapal==c2._nombrePapal && c1._nacionalidad == c2._nacionalidad)
            {
                comparar = true;
            }

            return comparar;
        }

        public static bool operator !=(Cardenal c1, Cardenal c2)
        {
            return !(c1 == c2);
        }

        public static Cardenal operator ++(Cardenal c1)
        {
            c1._cantVotosRecibidos++;

            return c1;
        }
    }
}
