namespace lab33
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblIntegrantes = new Label();
            grpProducto = new GroupBox();
            picProducto = new PictureBox();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            grpEntrega = new GroupBox();
            rdbDomicilio = new RadioButton();
            rdbLocal = new RadioButton();
            grpExtras = new GroupBox();
            chkDescuento = new CheckBox();
            chkPapas = new CheckBox();
            chkBebida = new CheckBox();
            chkQueso = new CheckBox();
            lblTotal = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            lstResumen = new ListBox();
            grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grpEntrega.SuspendLayout();
            grpExtras.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(413, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(234, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ";
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.AutoSize = true;
            lblIntegrantes.Location = new Point(456, 117);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(147, 30);
            lblIntegrantes.TabIndex = 1;
            lblIntegrantes.Text = "Roberto He / 8-1045-55\r\nAdrian De La Cruz / 8-1042";
            // 
            // grpProducto
            // 
            grpProducto.Controls.Add(picProducto);
            grpProducto.Controls.Add(nudCantidad);
            grpProducto.Controls.Add(cboProducto);
            grpProducto.Location = new Point(342, 163);
            grpProducto.Name = "grpProducto";
            grpProducto.Size = new Size(315, 237);
            grpProducto.TabIndex = 2;
            grpProducto.TabStop = false;
            grpProducto.Text = "Producto y Cantidad";
            // 
            // picProducto
            // 
            picProducto.Location = new Point(19, 64);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(266, 152);
            picProducto.TabIndex = 2;
            picProducto.TabStop = false;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(161, 31);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "Pizza - $8.00", "Hamburguesa - $6.00", "Ensalada - $5.00" });
            cboProducto.Location = new Point(21, 28);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(125, 23);
            cboProducto.TabIndex = 0;
            cboProducto.Text = "Items";
            // 
            // grpEntrega
            // 
            grpEntrega.Controls.Add(rdbDomicilio);
            grpEntrega.Controls.Add(rdbLocal);
            grpEntrega.Location = new Point(669, 164);
            grpEntrega.Name = "grpEntrega";
            grpEntrega.Size = new Size(257, 239);
            grpEntrega.TabIndex = 3;
            grpEntrega.TabStop = false;
            grpEntrega.Text = "Tipo de Entrega";
            // 
            // rdbDomicilio
            // 
            rdbDomicilio.AutoSize = true;
            rdbDomicilio.Location = new Point(21, 53);
            rdbDomicilio.Name = "rdbDomicilio";
            rdbDomicilio.Size = new Size(132, 19);
            rdbDomicilio.TabIndex = 1;
            rdbDomicilio.Text = "A domicilio (+$2.00)";
            rdbDomicilio.UseVisualStyleBackColor = true;
            // 
            // rdbLocal
            // 
            rdbLocal.AutoSize = true;
            rdbLocal.Checked = true;
            rdbLocal.Location = new Point(21, 28);
            rdbLocal.Name = "rdbLocal";
            rdbLocal.Size = new Size(167, 19);
            rdbLocal.TabIndex = 0;
            rdbLocal.TabStop = true;
            rdbLocal.Text = "Para comer en local ($0.00)";
            rdbLocal.UseVisualStyleBackColor = true;
            // 
            // grpExtras
            // 
            grpExtras.Controls.Add(chkDescuento);
            grpExtras.Controls.Add(chkPapas);
            grpExtras.Controls.Add(chkBebida);
            grpExtras.Controls.Add(chkQueso);
            grpExtras.Location = new Point(343, 410);
            grpExtras.Name = "grpExtras";
            grpExtras.Size = new Size(207, 137);
            grpExtras.TabIndex = 4;
            grpExtras.TabStop = false;
            grpExtras.Text = "Ingredientes / Extras";
            // 
            // chkDescuento
            // 
            chkDescuento.AutoSize = true;
            chkDescuento.Location = new Point(15, 99);
            chkDescuento.Name = "chkDescuento";
            chkDescuento.Size = new Size(182, 19);
            chkDescuento.TabIndex = 3;
            chkDescuento.Text = "Cliente Frecuente (10% Desc.)";
            chkDescuento.UseVisualStyleBackColor = true;
            // 
            // chkPapas
            // 
            chkPapas.AutoSize = true;
            chkPapas.Location = new Point(15, 74);
            chkPapas.Name = "chkPapas";
            chkPapas.Size = new Size(134, 19);
            chkPapas.TabIndex = 2;
            chkPapas.Text = "Papas Fritas (+$2.00)";
            chkPapas.UseVisualStyleBackColor = true;
            // 
            // chkBebida
            // 
            chkBebida.AutoSize = true;
            chkBebida.Location = new Point(15, 49);
            chkBebida.Name = "chkBebida";
            chkBebida.Size = new Size(108, 19);
            chkBebida.TabIndex = 1;
            chkBebida.Text = "Bebida (+$1.50)";
            chkBebida.UseVisualStyleBackColor = true;
            // 
            // chkQueso
            // 
            chkQueso.AutoSize = true;
            chkQueso.Location = new Point(15, 24);
            chkQueso.Name = "chkQueso";
            chkQueso.Size = new Size(134, 19);
            chkQueso.TabIndex = 0;
            chkQueso.Text = "Queso Extra (+$1.00)";
            chkQueso.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(565, 424);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(851, 420);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(690, 420);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstResumen
            // 
            lstResumen.FormattingEnabled = true;
            lstResumen.Location = new Point(575, 462);
            lstResumen.Name = "lstResumen";
            lstResumen.Size = new Size(349, 79);
            lstResumen.TabIndex = 7;
            lstResumen.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 650);
            Controls.Add(lstResumen);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(lblTotal);
            Controls.Add(grpExtras);
            Controls.Add(grpEntrega);
            Controls.Add(grpProducto);
            Controls.Add(lblIntegrantes);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            grpProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grpEntrega.ResumeLayout(false);
            grpEntrega.PerformLayout();
            grpExtras.ResumeLayout(false);
            grpExtras.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIntegrantes;
        private GroupBox grpProducto;
        private PictureBox picProducto;
        private NumericUpDown nudCantidad;
        private ComboBox cboProducto;
        private GroupBox grpEntrega;
        private RadioButton rdbDomicilio;
        private RadioButton rdbLocal;
        private GroupBox grpExtras;
        private CheckBox chkPapas;
        private CheckBox chkBebida;
        private CheckBox chkQueso;
        private CheckBox chkDescuento;
        private Label lblTotal;
        private Button btnLimpiar;
        private Button btnAgregar;
        private ListBox lstResumen;
    }
}
