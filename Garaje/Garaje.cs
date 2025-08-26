using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garaje
{
    internal class Garaje
    {
        public int numeroGaraje;
        public string descripcion;
        public int capacidadEspacios;
        public int espaciosOcupados;

        public object EspaciosOcupados { get; private set; }
        public object CapacidadEspacios { get; private set; }

        public Garaje(int numero, string descripcion, int capacidad, int ocupados)
        {
            this.numeroGaraje = numero;
            this.descripcion = descripcion;
            this.capacidadEspacios = capacidad;
            this.espaciosOcupados = ocupados;
        }


        public int EspaciosDisponibles()

        {
            return capacidadEspacios - espaciosOcupados;
        }
        public void ActualizarEspaciosOcupados(int solicitados)
        {
            EspaciosOcupados = EspaciosOcupados;
        }
    }
}
