using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pregunta2
{
    public partial class Form1 : Form
    {

        //Declarar la lista de equipos
        List<Equipo> Eqp = new List<Equipo>();
        

        public Form1()
        {
            
            InitializeComponent();
            txtNumeroSerie.Focus();
            cboMarca.SelectedIndex = 0;
            GenerarCodigo();
            txtFechaInventario.Text = Convert.ToString(DateTime.Now);
            
        }

        void GenerarCodigo()
        {

            //Generar el codigo del participante
            int cod = 0;
            if (Eqp.Count != 0)
            {
                //Obtener el codigo del ultimo Equipo 
                string ult = Eqp[Eqp.Count - 1].Codigo;
                cod = Convert.ToInt32(ult.Substring(3, 3));
            }
            cod++;
            txtCodigo.Text = "EQP" + cod.ToString().PadLeft(3, '0');

            
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            //Validar si el DNI ya fue registrado
            Equipo p = Eqp.Find(x => x.Codigo.Equals(txtCodigo.Text));
            if (p != null)
            {
                MessageBox.Show("El Codigo ya fue registrado anteriormente", "Registrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //Creacion de la clase equipo 
            Equipo obj = new Equipo();
            

            //Leemos los datos y asignamos al objeto 

            obj.Codigo = txtCodigo.Text;
            obj.NumeroSerie = txtNumeroSerie.Text;
            obj.Descripcion = txtDescripcion.Text;
            obj.FechaInventario = DateTime.Now;
            obj.Precio = Convert.ToDouble(txtPrecio.Text);

            Eqp.Add(obj);

            Limpiar();
            GenerarCodigo();
            txtFechaInventario.Text = Convert.ToString(DateTime.Now);
            txtNumeroSerie.Focus();


        }

        void Limpiar()
        {
            txtNumeroSerie.Clear();
            txtDescripcion.Clear();
            txtFechaInventario.Clear();
            txtPrecio.Clear();
           

        }

        

        private void btnModificar_Click(object sender, EventArgs e)
        {
           // Obtener el participante por el codigo
            Equipo obj = Eqp.Find(x => x.Codigo.Equals(txtCodigo.Text));

            if (obj == null)
            {
                MessageBox.Show("No se encontro el equipo a actualizar", "Actualizar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                obj.NumeroSerie = txtNumeroSerie.Text;
                obj.Descripcion = txtDescripcion.Text;
                obj.FechaInventario = DateTime.Now;
                obj.Precio = Convert.ToDouble(txtPrecio.Text);
               
                
                Limpiar();
                Listar();
                GenerarCodigo();
            }
        }
        void Listar() {


            lwInventario.Items.Clear();
            Object marca = cboMarca.SelectedItem;

            foreach (Equipo equipo in Eqp)
            {
                //Creamos un Item
                ListViewItem item = new ListViewItem(equipo.Codigo);



                //Crear los SubItems

                item.SubItems.Add(equipo.NumeroSerie);
                item.SubItems.Add(equipo.Descripcion);
                item.SubItems.Add(equipo.FechaInventario.ToString());
                item.SubItems.Add(marca.ToString());
                item.SubItems.Add(equipo.Precio.ToString());


                //Agregar el Item a la lista 
                lwInventario.Items.Add(item);

            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
