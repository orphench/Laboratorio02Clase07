using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conclave vaticano = 5;

            Cardenal c1 = new Cardenal("Angelo", "Pio XIII", ENacionalidades.Italiano);
            Cardenal c2 = new Cardenal("Roberto", "Juan XIV");
            Cardenal c3 = new Cardenal("Roberto", "Juam XVI");
            Cardenal c4 = new Cardenal("Juan", "Mateo I", ENacionalidades.Español);
            Cardenal c5 = new Cardenal("Mario", "Francisco I", ENacionalidades.Argentino);
            Cardenal c6 = new Cardenal("Jhon", "Peter II", ENacionalidades.Nigeriano);
            Cardenal c7 = new Cardenal("Jhon", "Peter II", ENacionalidades.Polaco);

            //vaticano += c1;

            c1.ObtenerNombreYNombrePapal();

            Console.ReadKey();
        }
    }
}
