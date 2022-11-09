namespace CityCarFrontEnd.Presentacion
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
            this.GroupFactura = new System.Windows.Forms.GroupBox();
            this.BtnListo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnNuevoCliente = new System.Windows.Forms.Button();
            this.LblNroFactura = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupDetalles = new System.Windows.Forms.GroupBox();
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
            this.CboClientes.Location = new System.Drawing.Point(539, 89);
            this.CboClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(140, 23);
            this.CboClientes.TabIndex = 0;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(257, 96);
            this.DtpFecha.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(116, 23);
            this.DtpFecha.TabIndex = 1;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(254, 136);
            this.TxtDescuento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtDescuento.MaxLength = 2;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(116, 23);
            this.TxtDescuento.TabIndex = 2;
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(539, 136);
            this.CboFormaPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(140, 23);
            this.CboFormaPago.TabIndex = 3;
            // 
            // GroupFactura
            // 
            this.GroupFactura.Controls.Add(this.BtnListo);
            this.GroupFactura.Controls.Add(this.label9);
            this.GroupFactura.Controls.Add(this.BtnNuevoCliente);
            this.GroupFactura.Controls.Add(this.LblNroFactura);
            this.GroupFactura.Controls.Add(this.label4);
            this.GroupFactura.Controls.Add(this.label3);
            this.GroupFactura.Controls.Add(this.label2);
            this.GroupFactura.Controls.Add(this.CboFormaPago);
            this.GroupFactura.Controls.Add(this.TxtDescuento);
            this.GroupFactura.Controls.Add(this.DtpFecha);
            this.GroupFactura.Controls.Add(this.CboClientes);
            this.GroupFactura.Location = new System.Drawing.Point(14, 14);
            this.GroupFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupFactura.Name = "GroupFactura";
            this.GroupFactura.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupFactura.Size = new System.Drawing.Size(905, 210);
            this.GroupFactura.TabIndex = 5;
            this.GroupFactura.TabStop = false;
            this.GroupFactura.Text = "Factura";
            // 
            // BtnListo
            // 
            this.BtnListo.Location = new System.Drawing.Point(696, 136);
            this.BtnListo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.Size = new System.Drawing.Size(88, 24);
            this.BtnListo.TabIndex = 13;
            this.BtnListo.Text = "Listo";
            this.BtnListo.UseVisualStyleBackColor = true;
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cliente";
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Location = new System.Drawing.Point(696, 89);
            this.BtnNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(88, 24);
            this.BtnNuevoCliente.TabIndex = 11;
            this.BtnNuevoCliente.Text = "Nuevo";
            this.BtnNuevoCliente.UseVisualStyleBackColor = true;
            this.BtnNuevoCliente.Click += new System.EventHandler(this.BtnNuevoCliente_Click);
            // 
            // LblNroFactura
            // 
            this.LblNroFactura.AutoSize = true;
            this.LblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNroFactura.Location = new System.Drawing.Point(98, 32);
            this.LblNroFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroFactura.Name = "LblNroFactura";
            this.LblNroFactura.Size = new System.Drawing.Size(94, 20);
            this.LblNroFactura.TabIndex = 10;
            this.LblNroFactura.Text = "Factura N°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Forma de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // GroupDetalles
            // 
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
            this.GroupDetalles.Controls.Add(this.CboProductos);
            this.GroupDetalles.Controls.Add(this.DtgDetalles);
            this.GroupDetalles.Location = new System.Drawing.Point(14, 231);
            this.GroupDetalles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupDetalles.Name = "GroupDetalles";
            this.GroupDetalles.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupDetalles.Size = new System.Drawing.Size(905, 419);
            this.GroupDetalles.TabIndex = 6;
            this.GroupDetalles.TabStop = false;
            this.GroupDetalles.Text = "Detalles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(771, 360);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(811, 358);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtTotal.MaxLength = 2;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(88, 23);
            this.TxtTotal.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(750, 332);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "SubTotal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(811, 385);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(88, 27);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Location = new System.Drawing.Point(811, 329);
            this.TxtSubtotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSubtotal.MaxLength = 2;
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(88, 23);
            this.TxtSubtotal.TabIndex = 15;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(7, 385);
            this.BtnConfirmar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(88, 27);
            this.BtnConfirmar.TabIndex = 14;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(506, 32);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(92, 23);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.Text = "1";
            // 
            // CboProductos
            // 
            this.CboProductos.FormattingEnabled = true;
            this.CboProductos.Location = new System.Drawing.Point(98, 32);
            this.CboProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboProductos.Name = "CboProductos";
            this.CboProductos.Size = new System.Drawing.Size(321, 23);
            this.CboProductos.TabIndex = 1;
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
            this.DtgDetalles.Location = new System.Drawing.Point(7, 66);
            this.DtgDetalles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.Size = new System.Drawing.Size(891, 256);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 659);
            this.Controls.Add(this.GroupDetalles);
            this.Controls.Add(this.GroupFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.GroupBox GroupFactura;
        private System.Windows.Forms.GroupBox GroupDetalles;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CboProductos;
        private System.Windows.Forms.Label LblNroFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn ColQuitar;
        private Button BtnListo;
    }
}