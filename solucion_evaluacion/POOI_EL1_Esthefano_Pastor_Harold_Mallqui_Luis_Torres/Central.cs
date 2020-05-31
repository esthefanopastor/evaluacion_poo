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

        public Central () {
            Cantidad = 2;
        }


        public double ObtenerDescuento()
        {
            double descuento = 0;
            if (Cantidad > 5)
            {
                descuento = ObtenerSubtotal() * 0.1;
                return descuento;
            }

            return descuento;
        }

        public virtual double ObtenerSubtotal()
        {
            double subtotal = 0;
            switch(NombreMedicamento)
            {
                case 0:
                    subtotal = 1.80;
                    break;
                case 1:
                    subtotal = 13.80;
                    break;
                case 2:
                    subtotal = 9.50;
                    break;
            }
            return subtotal;
        }
    }
}
