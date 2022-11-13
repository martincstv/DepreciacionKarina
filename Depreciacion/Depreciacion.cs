using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depreciacion
{
    public class Depreciacion
    {
        public int Numero { get; set; }
        public int Periodo { get; set; }
        public int N_Meses { get; set; }
        public float V_Depreciacion { get; set; }
        public float V_Actual { get; set; }


        public Depreciacion()
        {

        }

        public Depreciacion(int numero, int periodo, int n_Meses, float v_Depreciacion, float v_Actual)
        {
            Numero = numero;
            Periodo = periodo;
            N_Meses = n_Meses;
            V_Depreciacion = v_Depreciacion;
            V_Actual = v_Actual;
        }
    }
}