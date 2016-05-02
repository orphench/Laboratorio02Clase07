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

        public static explicit operator bool(Conclave con)
        {
            bool hayPapa = false;

            Conclave.ContarVotos(con);

            if (con._habemusPapa == true)
            {
                hayPapa = true;
            }

            return hayPapa;
        }

        private bool HayLugar()
        {
            bool hayLugar = false;

            if (this._cardenales.Count < this._cantMaxCardenales)
            {
                hayLugar = true;
            }

            else
            {
                Console.WriteLine("No hay más lugar!!!");
            }

            return hayLugar;
        }

        private string MostrarCardenales()
        {
            string respuesta = "";
            //Console.WriteLine("\n\nCARDENALES:");

            foreach (Cardenal item in _cardenales)
            {
               respuesta = respuesta + Cardenal.Mostrar(item);
            }

            
            return respuesta;
        }

        public string Mostrar()
        {
            //if (this._habemusPapa==true)
            //{
            //    return "HABEMUS PAPA " + _papa.ObtenerNombreYNombrePapal();
            //}

            //else
            //{
            //    return "\n\nLugar de la elección: " + this._lugarEleccion + "\nFecha: " + fechaVotacion.ToShortDateString() +
            //    "\nCantidad de votaciones: " + cantidadVotaciones + "\nNO HABEMUS PAPA!!!!\n" + MostrarCardenales();
            //}

            Console.WriteLine("\n\nLugar de la elección: " + this._lugarEleccion + "\nFecha: " + fechaVotacion.ToShortDateString() +
                "\nCantidad de votaciones: " + cantidadVotaciones);

            if (this._habemusPapa==false)
            {
                return "NO HABEMUS PAPA!!!!\n\nCARDENALES:\n" + MostrarCardenales();
            } 

            else
            {
                return "HABEMUS PAPA!!!!\n" + _papa.ObtenerNombreYNombrePapal();
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
                    break;
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
            if (con.HayLugar())
            {
               
                    if (con!=c)
                    {
                        con._cardenales.Add(c);
                    }
                else
                {
                    Console.WriteLine("El cardenal ya está en el Cónclave!!!");
                }
                
            }
            

            return con;
        }

        public static void VotarPapa(Conclave conclave)
        {
            Random obj = new Random();

            //for (int i = 0; i < conclave._cardenales.Count-1; i++)
           // {
                int indicePapal = obj.Next(0, conclave._cardenales.Count - 1);

                conclave._cardenales[indicePapal]++;
           // }

            

        }

        private static void ContarVotos(Conclave conclave)
        {
            for (int i = 0; i < conclave._cardenales.Count - 1; i++)
            {
                if (conclave._cardenales[i].getCantidadVotosRecibidos() >= 1)
                {
                    conclave._papa = conclave._cardenales[i];

                    conclave._habemusPapa = true;
                    break;
                }
            }


        }

    }
}
