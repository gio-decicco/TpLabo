namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmConsultarFacturas
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
            this.GroupFacturas = new System.Windows.Forms.GroupBox();
            this.LstFacturas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.CboAutoPlan = new System.Windows.Forms.ComboBox();
            this.CboFormasPago = new System.Windows.Forms.ComboBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtgDetalles = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.GroupFacturas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupFacturas
            // 
            this.GroupFacturas.Controls.Add(this.LstFacturas);
            this.GroupFacturas.Location = new System.Drawing.Point(12, 69);
            this.GroupFacturas.Name = "GroupFacturas";
            this.GroupFacturas.Size = new System.Drawing.Size(397, 298);
            this.GroupFacturas.TabIndex = 0;
            this.GroupFacturas.TabStop = false;
            this.GroupFacturas.Text = "Facturas";
            // 
            // LstFacturas
            // 
            this.LstFacturas.FormattingEnabled = true;
            this.LstFacturas.Location = new System.Drawing.Point(6, 19);
            this.LstFacturas.Name = "LstFacturas";
            this.LstFacturas.Size = new System.Drawing.Size(385, 264);
            this.LstFacturas.TabIndex = 0;
            this.LstFacturas.SelectedIndexChanged += new System.EventHandler(this.LstFacturas_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDescuento);
            this.groupBox2.Controls.Add(this.CboAutoPlan);
            this.groupBox2.Controls.Add(this.CboFormasPago);
            this.groupBox2.Controls.Add(this.TxtFecha);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LblFactura);
            this.groupBox2.Location = new System.Drawing.Point(415, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Factura";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Enabled = false;
            this.TxtDescuento.Location = new System.Drawing.Point(104, 177);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(250, 20);
            this.TxtDescuento.TabIndex = 10;
            // 
            // CboAutoPlan
            // 
            this.CboAutoPlan.Enabled = false;
            this.CboAutoPlan.FormattingEnabled = true;
            this.CboAutoPlan.Location = new System.Drawing.Point(95, 222);
            this.CboAutoPlan.Name = "CboAutoPlan";
            this.CboAutoPlan.Size = new System.Drawing.Size(259, 21);
            this.CboAutoPlan.TabIndex = 9;
            // 
            // CboFormasPago
            // 
            this.CboFormasPago.Enabled = false;
            this.CboFormasPago.FormattingEnabled = true;
            this.CboFormasPago.Location = new System.Drawing.Point(124, 132);
            this.CboFormasPago.Name = "CboFormasPago";
            this.CboFormasPago.Size = new System.Drawing.Size(230, 21);
            this.CboFormasPago.TabIndex = 8;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Location = new System.Drawing.Point(82, 87);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(272, 20);
            this.TxtFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "AutoPlan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forma de Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // LblFactura
            // 
            this.LblFactura.AutoSize = true;
            this.LblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFactura.Location = new System.Drawing.Point(38, 40);
            this.LblFactura.Name = "LblFactura";
            this.LblFactura.Size = new System.Drawing.Size(94, 20);
            this.LblFactura.TabIndex = 1;
            this.LblFactura.Text = "Factura N°";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // CboClientes
            // 
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(415, 28);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(260, 21);
            this.CboClientes.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtgDetalles);
            this.groupBox3.Location = new System.Drawing.Point(12, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(800, 275);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles";
            // 
            // DtgDetalles
            // 
            this.DtgDetalles.AllowUserToAddRows = false;
            this.DtgDetalles.AllowUserToDeleteRows = false;
            this.DtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColProducto,
            this.ColCantidad,
            this.ColPrecio,
            this.ColAcciones});
            this.DtgDetalles.Location = new System.Drawing.Point(6, 19);
            this.DtgDetalles.Name = "DtgDetalles";
            this.DtgDetalles.ReadOnly = true;
            this.DtgDetalles.Size = new System.Drawing.Size(788, 250);
            this.DtgDetalles.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColProducto
            // 
            this.ColProducto.HeaderText = "Producto";
            this.ColProducto.Name = "ColProducto";
            this.ColProducto.ReadOnly = true;
            this.ColProducto.Width = 410;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "Cantidad";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Precio";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(731, 656);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Enabled = false;
            this.BtnEliminar.Location = new System.Drawing.Point(18, 656);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Cliente";
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Location = new System.Drawing.Point(138, 28);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(178, 21);
            this.CboTipoCliente.TabIndex = 7;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(721, 28);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(85, 23);
            this.BtnCargar.TabIndex = 8;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // FrmConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 688);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.CboTipoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboClientes);
            this.Name = "FrmConsultarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarFacturas";
            this.Load += new System.EventHandler(this.FrmConsultarFacturas_Load);
            this.GroupFacturas.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupFacturas;
        private System.Windows.Forms.ListBox LstFacturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboClientes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.ComboBox CboAutoPlan;
        private System.Windows.Forms.ComboBox CboFormasPago;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.DataGridView DtgDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.Button BtnCargar;
    }
}