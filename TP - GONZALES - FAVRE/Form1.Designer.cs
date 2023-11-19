namespace TP___GONZALES___FAVRE
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
            this.numRepuesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Origen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtNumRep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radImport = new System.Windows.Forms.RadioButton();
            this.radNacional = new System.Windows.Forms.RadioButton();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // numRepuesto
            // 
            this.numRepuesto.AutoSize = true;
            this.numRepuesto.Location = new System.Drawing.Point(6, 54);
            this.numRepuesto.Name = "numRepuesto";
            this.numRepuesto.Size = new System.Drawing.Size(101, 13);
            this.numRepuesto.TabIndex = 0;
            this.numRepuesto.Text = "Numero Repuestos ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // Origen
            // 
            this.Origen.AutoSize = true;
            this.Origen.Location = new System.Drawing.Point(6, 121);
            this.Origen.Name = "Origen";
            this.Origen.Size = new System.Drawing.Size(38, 13);
            this.Origen.TabIndex = 2;
            this.Origen.Text = "Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion ";
            // 
            // textoPrecio
            // 
            this.textoPrecio.AutoSize = true;
            this.textoPrecio.Location = new System.Drawing.Point(21, 202);
            this.textoPrecio.Name = "textoPrecio";
            this.textoPrecio.Size = new System.Drawing.Size(37, 13);
            this.textoPrecio.TabIndex = 4;
            this.textoPrecio.Text = "Precio";
            this.textoPrecio.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(124, 195);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(125, 113);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(74, 21);
            this.cmbOrigen.TabIndex = 6;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(125, 83);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(74, 21);
            this.cmbMarca.TabIndex = 7;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(125, 159);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(220, 20);
            this.txtDescrip.TabIndex = 8;
            this.txtDescrip.TextChanged += new System.EventHandler(this.txtDescrip_TextChanged);
            // 
            // txtNumRep
            // 
            this.txtNumRep.Location = new System.Drawing.Point(125, 47);
            this.txtNumRep.Name = "txtNumRep";
            this.txtNumRep.Size = new System.Drawing.Size(121, 20);
            this.txtNumRep.TabIndex = 9;
            this.txtNumRep.TextChanged += new System.EventHandler(this.txtNumRep_TextChanged);
            this.txtNumRep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumRep_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtNumRep);
            this.groupBox1.Controls.Add(this.numRepuesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Origen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textoPrecio);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Location = new System.Drawing.Point(82, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 227);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Repuestos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dgvDatos);
            this.groupBox2.Controls.Add(this.radImport);
            this.groupBox2.Controls.Add(this.radNacional);
            this.groupBox2.Controls.Add(this.cmbOpciones);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(82, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 243);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de Repuestos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Marca,
            this.Origen1,
            this.Descripcion1,
            this.Precio});
            this.dgvDatos.Location = new System.Drawing.Point(34, 90);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(451, 147);
            this.dgvDatos.TabIndex = 6;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.Width = 75;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 50;
            // 
            // Origen1
            // 
            this.Origen1.HeaderText = "Origen";
            this.Origen1.Name = "Origen1";
            this.Origen1.Width = 50;
            // 
            // Descripcion1
            // 
            this.Descripcion1.HeaderText = "Descripcion ";
            this.Descripcion1.Name = "Descripcion1";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Width = 60;
            // 
            // radImport
            // 
            this.radImport.AutoSize = true;
            this.radImport.Location = new System.Drawing.Point(212, 67);
            this.radImport.Name = "radImport";
            this.radImport.Size = new System.Drawing.Size(75, 17);
            this.radImport.TabIndex = 5;
            this.radImport.TabStop = true;
            this.radImport.Text = "Importado ";
            this.radImport.UseVisualStyleBackColor = true;
            // 
            // radNacional
            // 
            this.radNacional.AutoSize = true;
            this.radNacional.Location = new System.Drawing.Point(124, 67);
            this.radNacional.Name = "radNacional";
            this.radNacional.Size = new System.Drawing.Size(67, 17);
            this.radNacional.TabIndex = 4;
            this.radNacional.TabStop = true;
            this.radNacional.Text = "Nacional";
            this.radNacional.UseVisualStyleBackColor = true;
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Location = new System.Drawing.Point(114, 25);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(121, 21);
            this.cmbOpciones.TabIndex = 2;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label numRepuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Origen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label textoPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtNumRep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radImport;
        private System.Windows.Forms.RadioButton radNacional;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button button3;
    }
}

