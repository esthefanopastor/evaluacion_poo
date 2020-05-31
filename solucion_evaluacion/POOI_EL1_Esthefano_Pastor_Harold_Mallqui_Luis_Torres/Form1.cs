using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOI_EL1_Esthefano_Pastor_Harold_Mallqui_Luis_Torres
{
    public partial class Form1 : Form
    {

        List<Central> Central = new List<Central>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Norte norte = new Norte
            {
                NombreMedicamento = cboNombreMedicamento.SelectedIndex
            };

            if (txtCantidadMedicamento.Text != "")
            {
                norte.Cantidad = Convert.ToInt32(txtCantidadMedicamento.Text);
            }

            double subtotal = norte.ObtenerSubtotal();

            double descuento = norte.ObtenerDescuento();

            double total = subtotal - descuento;

            ListViewItem item = new ListViewItem(cboNombreMedicamento.Text);
            item.SubItems.Add(norte.Cantidad.ToString());
            item.SubItems.Add("S/. " + norte.ObtenerSubtotal().ToString());
            item.SubItems.Add("S/. " + norte.ObtenerDescuento().ToString());
            item.SubItems.Add("S/. " + (norte.ObtenerSubtotal() - norte.ObtenerDescuento()).ToString());

            lwResultados.Items.Add(item);
        }
    }
}
