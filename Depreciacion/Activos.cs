using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacion
{
    public class Activos
    {
        public float PorcentajeAnual { get; set; }
        public int VidaUtilAnual { get; set; }
        public int NumeroMeses { get; set; }

        public Activos()
        {

        }

        public Activos(float porcentajeAnual, int vidaUtilAnual, int numeroMeses)
        {
            PorcentajeAnual = porcentajeAnual;
            VidaUtilAnual = vidaUtilAnual;
            NumeroMeses = numeroMeses;
        }

        public enum TipoActivo
        {   Seleccione,
            Inmueble,
            Vehiculo
        }
    }
}
