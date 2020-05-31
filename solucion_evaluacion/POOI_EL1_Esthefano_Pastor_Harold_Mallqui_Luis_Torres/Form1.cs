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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Central obj = new Central();

            //Leemos los datos y asignamos al objeto

            obj.NombreMedicamento = cboNomMed.SelectedIndex;
            obj.Cantidad = Convert.ToInt32(txtCantcom.Text);

            

               

            
        }
    }
}
