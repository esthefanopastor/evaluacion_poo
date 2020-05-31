using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_EL1_Esthefano_Pastor_Harold_Mallqui_Luis_Torres
{
    class Norte : Central
    {
        public override double ObtenerSubtotal()
        {
            double subTotal;

            switch (NombreMedicamento)
            {
                case 0:
                    subTotal = Cantidad * 1.50;
                    break;
                case 1:
                    subTotal = Cantidad * 12.50;
                    break;
                case 2:
                    subTotal = Cantidad * 8.90;
                    break;

                default:
                    subTotal = 0;
                    break;
            }
            return Math.Round(subTotal, 2);
        }

        public override double ObtenerDescuento()
        {
            double descuento = 0;
            if (ObtenerSubtotal() <= 30)
            {
                descuento = ObtenerSubtotal() * 0.05;
            }
            else
            {
                descuento = ObtenerSubtotal() * 0.07;
            }
            return Math.Round(descuento, 2);
        }
    }
}
