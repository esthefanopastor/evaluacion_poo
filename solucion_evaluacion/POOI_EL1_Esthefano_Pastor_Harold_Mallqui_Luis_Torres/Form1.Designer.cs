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
            this.txtCantcom = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboNomMed = new System.Windows.Forms.ComboBox();
            this.LwMostrar = new System.Windows.Forms.ListView();
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
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del medicamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad a comprar";
            // 
            // txtCantcom
            // 
            this.txtCantcom.Location = new System.Drawing.Point(277, 164);
            this.txtCantcom.Name = "txtCantcom";
            this.txtCantcom.Size = new System.Drawing.Size(188, 26);
            this.txtCantcom.TabIndex = 9;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(349, 505);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(116, 26);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cboNomMed
            // 
            this.cboNomMed.FormattingEnabled = true;
            this.cboNomMed.Items.AddRange(new object[] {
            "Azitromicina 500 mg",
            "Ivermectina 6mg ",
            "Hidroxicloriquina 400mg"});
            this.cboNomMed.Location = new System.Drawing.Point(277, 119);
            this.cboNomMed.Name = "cboNomMed";
            this.cboNomMed.Size = new System.Drawing.Size(187, 28);
            this.cboNomMed.TabIndex = 14;
            // 
            // LwMostrar
            // 
            this.LwMostrar.HideSelection = false;
            this.LwMostrar.Location = new System.Drawing.Point(39, 245);
            this.LwMostrar.Name = "LwMostrar";
            this.LwMostrar.Size = new System.Drawing.Size(427, 223);
            this.LwMostrar.TabIndex = 17;
            this.LwMostrar.UseCompatibleStateImageBehavior = false;
            this.LwMostrar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 556);
            this.Controls.Add(this.LwMostrar);
            this.Controls.Add(this.cboNomMed);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.txtCantcom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Simulador 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantcom;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboNomMed;
        private System.Windows.Forms.ListView LwMostrar;
    }
}

