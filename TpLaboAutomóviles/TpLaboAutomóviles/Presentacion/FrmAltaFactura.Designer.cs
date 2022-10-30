namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmAltaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.CboFormaPago = new System.Windows.Forms.ComboBox();
            this.CboAutoPlan = new System.Windows.Forms.ComboBox();
            this.GroupFactura = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtInteres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCuotas = new System.Windows.Forms.TextBox();
            this.BtnListo = new System.Windows.Forms.Button();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.LblNroFactura = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupDetalles = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipoProducto = new System.Windows.Forms.ComboBox();
            this.CboProductos = new System.Windows.Forms.ComboBox();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GroupFactura.SuspendLayout();
            this.GroupDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // CboClientes
            // 
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(616, 95);
            this.CboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(160, 24);
            this.CboClientes.TabIndex = 0;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(281, 153);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(132, 22);
            this.DtpFecha.TabIndex = 1;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Location = new System.Drawing.Point(281, 203);
            this.TxtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescuento.MaxLength = 2;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(132, 22);
            this.TxtDescuento.TabIndex = 2;
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(616, 145);
            this.CboFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(160, 24);
            this.CboFormaPago.TabIndex = 3;
            // 
            // CboAutoPlan
            // 
            this.CboAutoPlan.Enabled = false;
            this.CboAutoPlan.FormattingEnabled = true;
            this.CboAutoPlan.Location = new System.Drawing.Point(616, 199);
            this.CboAutoPlan.Margin = new System.Windows.Forms.Padding(4);
            this.CboAutoPlan.Name = "CboAutoPlan";
            this.CboAutoPlan.Size = new System.Drawing.Size(160, 24);
            this.CboAutoPlan.TabIndex = 4;
            this.CboAutoPlan.SelectedIndexChanged += new System.EventHandler(this.CboAutoPlan_SelectedIndexChanged);
            // 
            // GroupFactura
            // 
            this.GroupFactura.Controls.Add(this.label13);
            this.GroupFactura.Controls.Add(this.TxtInteres);
            this.GroupFactura.Controls.Add(this.label12);
            this.GroupFactura.Controls.Add(this.TxtCuotas);
            this.GroupFactura.Controls.Add(this.BtnListo);
            this.GroupFactura.Controls.Add(this.CboTipoCliente);
            this.GroupFactura.Controls.Add(this.label9);
            this.GroupFactura.Controls.Add(this.BtnNuevoCliente);
            this.GroupFactura.Controls.Add(this.LblNroFactura);
            this.GroupFactura.Controls.Add(this.label5);
            this.GroupFactura.Controls.Add(this.label4);
            this.GroupFactura.Controls.Add(this.label3);
            this.GroupFactura.Controls.Add(this.label2);
            this.GroupFactura.Controls.Add(this.label1);
            this.GroupFactura.Controls.Add(this.CboAutoPlan);
            this.GroupFactura.Controls.Add(this.CboFormaPago);
            this.GroupFactura.Controls.Add(this.TxtDescuento);
            this.GroupFactura.Controls.Add(this.DtpFecha);
            this.GroupFactura.Controls.Add(this.CboClientes);
            this.GroupFactura.Location = new System.Drawing.Point(16, 15);
            this.GroupFactura.Margin = new System.Windows.Forms.Padding(4);
            this.GroupFactura.Name = "GroupFactura";
            this.GroupFactura.Padding = new System.Windows.Forms.Padding(4);
            this.GroupFactura.Size = new System.Drawing.Size(1035, 282);
            this.GroupFactura.TabIndex = 5;
            this.GroupFactura.TabStop = false;
            this.GroupFactura.Text = "Factura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(712, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Interés";
            // 
            // TxtInteres
            // 
            this.TxtInteres.Enabled = false;
            this.TxtInteres.Location = new System.Drawing.Point(767, 235);
            this.TxtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInteres.MaxLength = 2;
            this.TxtInteres.Name = "TxtInteres";
            this.TxtInteres.Size = new System.Drawing.Size(82, 22);
            this.TxtInteres.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 238);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Cuotas";
            // 
            // TxtCuotas
            // 
            this.TxtCuotas.Enabled = false;
            this.TxtCuotas.Location = new System.Drawing.Point(616, 235);
            this.TxtCuotas.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCuotas.MaxLength = 2;
            this.TxtCuotas.Name = "TxtCuotas";
            this.TxtCuotas.Size = new System.Drawing.Size(82, 22);
            this.TxtCuotas.TabIndex = 15;
            // 
            // BtnListo
            // 
            this.BtnListo.Location = new System.Drawing.Point(886, 235);
            this.BtnListo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.Size = new System.Drawing.Size(125, 23);
            this.BtnListo.TabIndex = 14;
            this.BtnListo.Text = "Listo";
            this.BtnListo.UseVisualStyleBackColor = true;
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Location = new System.Drawing.Point(281, 94);
            this.CboTipoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(164, 24);
            this.CboTipoCliente.TabIndex = 13;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cliente";
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Location = new System.Drawing.Point(796, 95);
            this.BtnNuevoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(100, 26);
            this.BtnNuevoCliente.TabIndex = 11;
            this.BtnNuevoCliente.Text = "Nuevo";
            this.BtnNuevoCliente.UseVisualStyleBackColor = true;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // LblNroFactura
            // 
            this.LblNroFactura.AutoSize = true;
            this.LblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroFactura.Location = new System.Drawing.Point(112, 34);
            this.LblNroFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroFactura.Name = "LblNroFactura";
            this.LblNroFactura.Size = new System.Drawing.Size(115, 25);
            this.LblNroFactura.TabIndex = 10;
            this.LblNroFactura.Text = "Factura N°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Auto Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Forma de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Cliente";
            // 
            // GroupDetalles
            // 
            this.GroupDetalles.Controls.Add(this.label14);
            this.GroupDetalles.Controls.Add(this.TxtStock);
            this.GroupDetalles.Controls.Add(this.label11);
            this.GroupDetalles.Controls.Add(this.TxtTotal);
            this.GroupDetalles.Controls.Add(this.label10);
            this.GroupDetalles.Controls.Add(this.BtnCancelar);
            this.GroupDetalles.Controls.Add(this.TxtSubtotal);
            this.GroupDetalles.Controls.Add(this.BtnConfirmar);
            this.GroupDetalles.Controls.Add(this.button1);
            this.GroupDetalles.Controls.Add(this.label8);
            this.GroupDetalles.Controls.Add(this.label7);
            this.GroupDetalles.Controls.Add(this.TxtCantidad);
            this.GroupDetalles.Controls.Add(this.label6);
            this.GroupDetalles.Controls.Add(this.CboTipoProducto);
            this.GroupDetalles.Controls.Add(this.CboProductos);
            this.GroupDetalles.Controls.Add(this.DtgDetalles);
            this.GroupDetalles.Location = new System.Drawing.Point(16, 304);
            this.GroupDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.GroupDetalles.Name = "GroupDetalles";
            this.GroupDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.GroupDetalles.Size = new System.Drawing.Size(1035, 447);
            this.GroupDetalles.TabIndex = 6;
            this.GroupDetalles.TabStop = false;
            this.GroupDetalles.Text = "Detalles";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(598, 38);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Stock Actual";
            // 
            // TxtStock
            // 
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(687, 35);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(72, 22);
            this.TxtStock.TabIndex = 19;
            this.TxtStock.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(881, 384);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(927, 381);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotal.MaxLength = 2;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(857, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "SubTotal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(927, 411);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(927, 351);
            this.TxtSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSubtotal.MaxLength = 2;
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.TxtSubtotal.TabIndex = 15;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(8, 411);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.BtnConfirmar.TabIndex = 14;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(907, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 26);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(777, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(851, 35);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(37, 22);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Producto";
            // 
            // CboTipoProducto
            // 
            this.CboTipoProducto.FormattingEnabled = true;
            this.CboTipoProducto.Location = new System.Drawing.Point(152, 34);
            this.CboTipoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipoProducto.Name = "CboTipoProducto";
            this.CboTipoProducto.Size = new System.Drawing.Size(160, 24);
            this.CboTipoProducto.TabIndex = 2;
            this.CboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.CboTipoProducto_SelectedIndexChanged);
            // 
            // CboProductos
            // 
            this.CboProductos.FormattingEnabled = true;
            this.CboProductos.Location = new System.Drawing.Point(410, 34);
            this.CboProductos.Margin = new System.Windows.Forms.Padding(4);
            this.CboProductos.Name = "CboProductos";
            this.CboProductos.Size = new System.Drawing.Size(160, 24);
            this.CboProductos.TabIndex = 1;
            this.CboProductos.SelectedIndexChanged += new System.EventHandler(this.CboProductos_SelectedIndexChanged);
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColProducto,
            this.ColCantidad,
            this.ColPrecio,
            this.ColQuitar});
            this.DtgDetalles.Location = new System.Drawing.Point(8, 70);
            this.DtgDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.Size = new System.Drawing.Size(1019, 273);
            this.DtgDetalles.TabIndex = 0;
            this.DtgDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 125;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.MinimumWidth = 6;
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 550;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.MinimumWidth = 6;
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 125;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 125;
            // 
            // ColQuitar
            // 
            this.ColQuitar.HeaderText = "Acciones";
            this.ColQuitar.MinimumWidth = 6;
            this.ColQuitar.Name = "ColQuitar";
            this.ColQuitar.ReadOnly = true;
            this.ColQuitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColQuitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColQuitar.Text = "Quitar";
            this.ColQuitar.ToolTipText = "Quitar";
            this.ColQuitar.Width = 125;
            // 
            // FrmAltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 766);
            this.Controls.Add(this.GroupDetalles);
            this.Controls.Add(this.GroupFactura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAltaFactura";
            this.Load += new System.EventHandler(this.FrmAltaFactura_Load);
            this.GroupFactura.ResumeLayout(false);
            this.GroupFactura.PerformLayout();
            this.GroupDetalles.ResumeLayout(false);
            this.GroupDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CboClientes;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.ComboBox CboFormaPago;
        private System.Windows.Forms.ComboBox CboAutoPlan;
        private System.Windows.Forms.GroupBox GroupFactura;
        private System.Windows.Forms.GroupBox GroupDetalles;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CboTipoProducto;
        private System.Windows.Forms.ComboBox CboProductos;
        private System.Windows.Forms.Label LblNroFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnListo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCuotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtInteres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn ColQuitar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtStock;
    }
}