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
            lblResultados = new Label();
            cmdCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(51, 122);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(62, 28);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha";
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioUnitario.Location = new Point(51, 378);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(138, 25);
            lblPrecioUnitario.TabIndex = 1;
            lblPrecioUnitario.Text = "Precio Unitario";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(51, 290);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(88, 25);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProducto.Location = new Point(51, 208);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 25);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Producto";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(51, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 28);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Registro de Venta";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(215, 122);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(273, 27);
            dtpFecha.TabIndex = 5;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.Items.AddRange(new object[] { "Monitor ", "Teclado", "Unidad Central de Procesamiento (CPU)", "Placa base", "Memoria RAM", "Altavoces" });
            lstProductos.Location = new Point(215, 212);
            lstProductos.Margin = new Padding(3, 4, 3, 4);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(258, 28);
            lstProductos.TabIndex = 6;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // cmdAceptar
            // 
            cmdAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdAceptar.Location = new Point(51, 464);
            cmdAceptar.Margin = new Padding(3, 4, 3, 4);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(110, 40);
            cmdAceptar.TabIndex = 9;
            cmdAceptar.Text = "ACEPTAR";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(218, 289);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(255, 27);
            nudCantidad.TabIndex = 10;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(218, 376);
            mtbPrecio.Mask = "99999$";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(255, 27);
            mtbPrecio.TabIndex = 11;
            mtbPrecio.ValidatingType = typeof(int);
            mtbPrecio.MaskInputRejected += mtbPrecio_MaskInputRejected;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(145, 534);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(0, 20);
            lblResultados.TabIndex = 12;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdCancelar.Location = new Point(218, 464);
            cmdCancelar.Margin = new Padding(3, 4, 3, 4);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(138, 40);
            cmdCancelar.TabIndex = 13;
            cmdCancelar.Text = "CANCELAR";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 540);
            Controls.Add(cmdCancelar);
            Controls.Add(lblResultados);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private NumericUpDown nudCantidad;
        private Button cmdAceptar;
        private MaskedTextBox mtbPrecio;
        private Label lblResultados;
        private Button cmdCancelar;
    }
}
