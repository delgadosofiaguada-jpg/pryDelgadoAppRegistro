namespace pryDelgadoAppRegistro
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            lblFecha = new Label();
            lblPrecioUnitario = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            lblTitulo = new Label();
            dtpFecha = new DateTimePicker();
            lstProductos = new ComboBox();
            cmdAceptar = new Button();
            nudCantidad = new NumericUpDown();
            mtbPrecio = new MaskedTextBox();
            cmdCancelar = new Button();
            lblResultado = new Label();
            lstbRegistros = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(12, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 21);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(12, 277);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(107, 20);
            lblPrecioUnitario.TabIndex = 1;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(12, 211);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(12, 149);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 21);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registro de Venta";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(156, 85);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(226, 23);
            dtpFecha.TabIndex = 5;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // lstProductos
            // 
            lstProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            lstProductos.Enabled = false;
            lstProductos.FormattingEnabled = true;
            lstProductos.Items.AddRange(new object[] { " teclado", "pantalla", "memoria RAM", "disco rígido", "mouse" });
            lstProductos.Location = new Point(156, 152);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(226, 23);
            lstProductos.TabIndex = 6;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Enabled = false;
            cmdAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAceptar.Location = new Point(15, 332);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(96, 30);
            cmdAceptar.TabIndex = 9;
            cmdAceptar.Text = "ACEPTAR";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Enabled = false;
            nudCantidad.Location = new Point(156, 211);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(226, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Enabled = false;
            mtbPrecio.Location = new Point(156, 278);
            mtbPrecio.Mask = "99999$";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(227, 23);
            mtbPrecio.TabIndex = 11;
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(150, 332);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(111, 30);
            cmdCancelar.TabIndex = 12;
            cmdCancelar.Text = "CANCELAR";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(15, 399);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(64, 15);
            lblResultado.TabIndex = 14;
            lblResultado.Text = "Resultados";
            lblResultado.Click += lblResultado_Click;
            // 
            // lstbRegistros
            // 
            lstbRegistros.FormattingEnabled = true;
            lstbRegistros.ItemHeight = 15;
            lstbRegistros.Location = new Point(18, 420);
            lstbRegistros.Name = "lstbRegistros";
            lstbRegistros.Size = new Size(365, 124);
            lstbRegistros.TabIndex = 15;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 549);
            Controls.Add(lstbRegistros);
            Controls.Add(lblResultado);
            Controls.Add(cmdCancelar);
            Controls.Add(mtbPrecio);
            Controls.Add(nudCantidad);
            Controls.Add(cmdAceptar);
            Controls.Add(lstProductos);
            Controls.Add(dtpFecha);
            Controls.Add(lblTitulo);
            Controls.Add(lblProducto);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(lblFecha);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblPrecioUnitario;
        private Label lblCantidad;
        private Label lblProducto;
        private Label lblTitulo;
        private DateTimePicker dtpFecha;
        private ComboBox lstProductos;
        private NumericUpDown numericUpDown1;
        private Button cmdAceptar;
        private NumericUpDown nudCantidad;
        private MaskedTextBox mtbPrecio;
        private Button cmdCancelar;
        private Label lblResultado;
        private ListBox lstbRegistros;
    }
}
