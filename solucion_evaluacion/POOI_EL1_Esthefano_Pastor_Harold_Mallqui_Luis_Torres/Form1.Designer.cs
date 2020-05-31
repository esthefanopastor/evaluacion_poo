namespace POOI_EL1_Esthefano_Pastor_Harold_Mallqui_Luis_Torres
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadMedicamento = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboNombreMedicamento = new System.Windows.Forms.ComboBox();
            this.lwResultados = new System.Windows.Forms.ListView();
            this.nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIMULADOR DE VENTA DE MEDICAMENTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad a comprar";
            // 
            // txtCantidadMedicamento
            // 
            this.txtCantidadMedicamento.Location = new System.Drawing.Point(261, 160);
            this.txtCantidadMedicamento.Name = "txtCantidadMedicamento";
            this.txtCantidadMedicamento.Size = new System.Drawing.Size(218, 26);
            this.txtCantidadMedicamento.TabIndex = 9;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(658, 518);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(116, 26);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboNombreMedicamento
            // 
            this.cboNombreMedicamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNombreMedicamento.FormattingEnabled = true;
            this.cboNombreMedicamento.Items.AddRange(new object[] {
            "Azitromicina 500 mg",
            "Ivermectina 6mg ",
            "Hidroxicloriquina 400mg"});
            this.cboNombreMedicamento.SelectedIndex = 0;
            this.cboNombreMedicamento.Location = new System.Drawing.Point(262, 117);
            this.cboNombreMedicamento.Name = "cboNombreMedicamento";
            this.cboNombreMedicamento.Size = new System.Drawing.Size(217, 28);
            this.cboNombreMedicamento.TabIndex = 14;
            // 
            // lwResultados
            // 
            this.lwResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombre,
            this.cantidad,
            this.subtotal,
            this.descuento,
            this.total});
            this.lwResultados.HideSelection = false;
            this.lwResultados.Location = new System.Drawing.Point(12, 241);
            this.lwResultados.Name = "lwResultados";
            this.lwResultados.Size = new System.Drawing.Size(762, 223);
            this.lwResultados.TabIndex = 17;
            this.lwResultados.UseCompatibleStateImageBehavior = false;
            this.lwResultados.View = System.Windows.Forms.View.Details;
            // 
            // nombre
            // 
            this.nombre.Text = "Nombre";
            this.nombre.Width = 204;
            // 
            // cantidad
            // 
            this.cantidad.Text = "Cantidad";
            this.cantidad.Width = 112;
            // 
            // subtotal
            // 
            this.subtotal.Text = "Subtotal";
            this.subtotal.Width = 148;
            // 
            // descuento
            // 
            this.descuento.Text = "Descuento";
            this.descuento.Width = 155;
            // 
            // total
            // 
            this.total.Text = "Total";
            this.total.Width = 139;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 556);
            this.Controls.Add(this.lwResultados);
            this.Controls.Add(this.cboNombreMedicamento);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtCantidadMedicamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Simulador 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadMedicamento;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboNombreMedicamento;
        private System.Windows.Forms.ListView lwResultados;
        private System.Windows.Forms.ColumnHeader nombre;
        private System.Windows.Forms.ColumnHeader cantidad;
        private System.Windows.Forms.ColumnHeader subtotal;
        private System.Windows.Forms.ColumnHeader descuento;
        private System.Windows.Forms.ColumnHeader total;
    }
}

