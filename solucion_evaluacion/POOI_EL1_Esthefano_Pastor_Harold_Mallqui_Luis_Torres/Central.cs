using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_EL1_Esthefano_Pastor_Harold_Mallqui_Luis_Torres
{
    public class Central
    {
        public int NombreMedicamento { get; set; }
        public int Cantidad { get; set; }

        public virtual double ObtenerSubtotal()
        {
            return 1.0;
        }

        public virtual double ObtenerDescuento()
        {
            return 1.0;
        }
    }
}
