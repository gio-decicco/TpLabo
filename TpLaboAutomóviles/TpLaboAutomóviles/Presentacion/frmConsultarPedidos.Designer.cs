namespace TpLaboAutomóviles.Presentacion
{
    partial class frmConsultarPedidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDetallesPedido = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colNumPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Pedidos";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnConsultar);
            this.gbFiltros.Controls.Add(this.cboTipoCliente);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.cboCliente);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Location = new System.Drawing.Point(36, 84);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(764, 114);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(500, 43);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 36);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(134, 26);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(260, 24);
            this.cboTipoCliente.TabIndex = 0;
            this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Cliente";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(134, 73);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(260, 24);
            this.cboCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumPedido,
            this.colFechaOrden,
            this.colFechaPedido,
            this.colCliente,
            this.colAcciones});
            this.dgvConsulta.Location = new System.Drawing.Point(36, 213);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.RowTemplate.Height = 24;
            this.dgvConsulta.Size = new System.Drawing.Size(764, 345);
            this.dgvConsulta.TabIndex = 0;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(36, 595);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 36);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(256, 595);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(145, 34);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1203, 595);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDetallesPedido
            // 
            this.dgvDetallesPedido.AllowUserToAddRows = false;
            this.dgvDetallesPedido.AllowUserToDeleteRows = false;
            this.dgvDetallesPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProducto,
            this.colProducto,
            this.colPrecio,
            this.colCantidad});
            this.dgvDetallesPedido.Location = new System.Drawing.Point(837, 213);
            this.dgvDetallesPedido.Name = "dgvDetallesPedido";
            this.dgvDetallesPedido.ReadOnly = true;
            this.dgvDetallesPedido.RowHeadersWidth = 51;
            this.dgvDetallesPedido.RowTemplate.Height = 24;
            this.dgvDetallesPedido.Size = new System.Drawing.Size(511, 345);
            this.dgvDetallesPedido.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Detalles del Pedido ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(837, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // colNumPedido
            // 
            this.colNumPedido.HeaderText = "Nº Pedido";
            this.colNumPedido.MinimumWidth = 6;
            this.colNumPedido.Name = "colNumPedido";
            this.colNumPedido.ReadOnly = true;
            this.colNumPedido.Width = 50;
            // 
            // colFechaOrden
            // 
            this.colFechaOrden.HeaderText = "Fecha Orden";
            this.colFechaOrden.MinimumWidth = 6;
            this.colFechaOrden.Name = "colFechaOrden";
            this.colFechaOrden.ReadOnly = true;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.HeaderText = "Fecha Pedido";
            this.colFechaPedido.MinimumWidth = 6;
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 125;
            // 
            // colAcciones
            // 
            this.colAcciones.HeaderText = "Ver Detalles";
            this.colAcciones.MinimumWidth = 6;
            this.colAcciones.Name = "colAcciones";
            this.colAcciones.ReadOnly = true;
            this.colAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAcciones.Text = "Ver Detalle";
            this.colAcciones.UseColumnTextForButtonValue = true;
            this.colAcciones.Width = 125;
            // 
            // colIdProducto
            // 
            this.colIdProducto.HeaderText = "idProducto";
            this.colIdProducto.MinimumWidth = 6;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.ReadOnly = true;
            this.colIdProducto.Visible = false;
            this.colIdProducto.Width = 50;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 125;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 125;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MinimumWidth = 6;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 75;
            // 
            // frmConsultarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetallesPedido);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultarPedidos";
            this.Text = "frmConsultarPedidos";
            this.Load += new System.EventHandler(this.frmConsultarPedidos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDetallesPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewButtonColumn colAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
    }
}