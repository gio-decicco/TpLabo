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
            this.BtnCancelar = new System.Windows.Forms.Button();
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
            this.ColQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GroupFactura.SuspendLayout();
            this.GroupDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // CboClientes
            // 
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(462, 77);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(121, 21);
            this.CboClientes.TabIndex = 0;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(211, 124);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(100, 20);
            this.DtpFecha.TabIndex = 1;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Location = new System.Drawing.Point(211, 165);
            this.TxtDescuento.MaxLength = 2;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 20);
            this.TxtDescuento.TabIndex = 2;
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(462, 118);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(121, 21);
            this.CboFormaPago.TabIndex = 3;
            // 
            // CboAutoPlan
            // 
            this.CboAutoPlan.FormattingEnabled = true;
            this.CboAutoPlan.Location = new System.Drawing.Point(462, 165);
            this.CboAutoPlan.Name = "CboAutoPlan";
            this.CboAutoPlan.Size = new System.Drawing.Size(121, 21);
            this.CboAutoPlan.TabIndex = 4;
            // 
            // GroupFactura
            // 
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
            this.GroupFactura.Location = new System.Drawing.Point(12, 12);
            this.GroupFactura.Name = "GroupFactura";
            this.GroupFactura.Size = new System.Drawing.Size(776, 229);
            this.GroupFactura.TabIndex = 5;
            this.GroupFactura.TabStop = false;
            this.GroupFactura.Text = "Factura";
            // 
            // BtnListo
            // 
            this.BtnListo.Location = new System.Drawing.Point(597, 166);
            this.BtnListo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnListo.Name = "BtnListo";
            this.BtnListo.Size = new System.Drawing.Size(94, 19);
            this.BtnListo.TabIndex = 14;
            this.BtnListo.Text = "Listo";
            this.BtnListo.UseVisualStyleBackColor = true;
            this.BtnListo.Click += new System.EventHandler(this.BtnListo_Click);
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Location = new System.Drawing.Point(211, 76);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(124, 21);
            this.CboTipoCliente.TabIndex = 13;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cliente";
            // 
            // BtnNuevoCliente
            // 
            this.BtnNuevoCliente.Location = new System.Drawing.Point(597, 77);
            this.BtnNuevoCliente.Name = "BtnNuevoCliente";
            this.BtnNuevoCliente.Size = new System.Drawing.Size(75, 21);
            this.BtnNuevoCliente.TabIndex = 11;
            this.BtnNuevoCliente.Text = "Nuevo";
            this.BtnNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // LblNroFactura
            // 
            this.LblNroFactura.AutoSize = true;
            this.LblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNroFactura.Location = new System.Drawing.Point(84, 28);
            this.LblNroFactura.Name = "LblNroFactura";
            this.LblNroFactura.Size = new System.Drawing.Size(94, 20);
            this.LblNroFactura.TabIndex = 10;
            this.LblNroFactura.Text = "Factura N°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Auto Plan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Forma de Pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Cliente";
            // 
            // GroupDetalles
            // 
            this.GroupDetalles.Controls.Add(this.BtnCancelar);
            this.GroupDetalles.Controls.Add(this.BtnConfirmar);
            this.GroupDetalles.Controls.Add(this.button1);
            this.GroupDetalles.Controls.Add(this.label8);
            this.GroupDetalles.Controls.Add(this.label7);
            this.GroupDetalles.Controls.Add(this.TxtCantidad);
            this.GroupDetalles.Controls.Add(this.label6);
            this.GroupDetalles.Controls.Add(this.CboTipoProducto);
            this.GroupDetalles.Controls.Add(this.CboProductos);
            this.GroupDetalles.Controls.Add(this.DtgDetalles);
            this.GroupDetalles.Location = new System.Drawing.Point(12, 247);
            this.GroupDetalles.Name = "GroupDetalles";
            this.GroupDetalles.Size = new System.Drawing.Size(776, 363);
            this.GroupDetalles.TabIndex = 6;
            this.GroupDetalles.TabStop = false;
            this.GroupDetalles.Text = "Detalles";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(695, 334);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 15;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(6, 334);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirmar.TabIndex = 14;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 21);
            this.button1.TabIndex = 13;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Producto";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(554, 29);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Producto";
            // 
            // CboTipoProducto
            // 
            this.CboTipoProducto.FormattingEnabled = true;
            this.CboTipoProducto.Location = new System.Drawing.Point(114, 28);
            this.CboTipoProducto.Name = "CboTipoProducto";
            this.CboTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.CboTipoProducto.TabIndex = 2;
            this.CboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.CboTipoProducto_SelectedIndexChanged);
            // 
            // CboProductos
            // 
            this.CboProductos.FormattingEnabled = true;
            this.CboProductos.Location = new System.Drawing.Point(341, 28);
            this.CboProductos.Name = "CboProductos";
            this.CboProductos.Size = new System.Drawing.Size(121, 21);
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
            this.ColQuitar});
            this.DtgDetalles.Location = new System.Drawing.Point(6, 57);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.RowHeadersWidth = 51;
            this.DtgDetalles.Size = new System.Drawing.Size(764, 274);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.GroupDetalles);
            this.Controls.Add(this.GroupFactura);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn ColQuitar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnNuevoCliente;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnListo;
    }
}