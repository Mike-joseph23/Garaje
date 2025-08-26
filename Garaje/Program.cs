using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garaje miGaraje = new Garaje(1, "Garaje A", 50, 20);

            Console.WriteLine("Espacios disponibles: " + miGaraje.EspaciosDisponibles());

            miGaraje.ActualizarEspaciosOcupados(5);


            Console.WriteLine("Espacios disponibles despues de actualizar: " + miGaraje.EspaciosDisponibles());
        }
    }
}
