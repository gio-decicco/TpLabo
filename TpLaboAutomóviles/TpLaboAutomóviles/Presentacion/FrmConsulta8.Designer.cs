namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmConsulta8
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblConsigna = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescripcion,
            this.colPrecio});
            this.dgvProductos.Location = new System.Drawing.Point(16, 262);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(858, 442);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // lblConsigna
            // 
            this.lblConsigna.AutoSize = true;
            this.lblConsigna.Location = new System.Drawing.Point(32, 25);
            this.lblConsigna.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsigna.Name = "lblConsigna";
            this.lblConsigna.Size = new System.Drawing.Size(458, 32);
            this.lblConsigna.TabIndex = 1;
            this.lblConsigna.Text = "--Crear y ejecutar un procedimiento almacenado que muestre los productos \r\nque te" +
    "ngan su precio entre determinados números";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(390, 212);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(47, 79);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(57, 17);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "*NOTA";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(60, 95);
            this.lblNota2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(359, 16);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "El número de la izquierda debe ser menor al de la derecha.";
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(120, 159);
            this.nudMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(277, 22);
            this.nudMin.TabIndex = 7;
            this.nudMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(499, 159);
            this.nudMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(274, 22);
            this.nudMax.TabIndex = 8;
            this.nudMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Location = new System.Drawing.Point(495, 139);
            this.lblMaximo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(54, 16);
            this.lblMaximo.TabIndex = 9;
            this.lblMaximo.Text = "Máximo";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Location = new System.Drawing.Point(117, 139);
            this.lblMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(50, 16);
            this.lblMinimo.TabIndex = 10;
            this.lblMinimo.Text = "Minimo";
            // 
            // colId
            // 
            this.colId.HeaderText = "Id_Producto";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 125;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.MinimumWidth = 6;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 350;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 260;
            // 
            // FrmConsulta8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 717);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.nudMax);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblConsigna);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsulta8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsulta8";
            this.Load += new System.EventHandler(this.FrmConsulta8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblConsigna;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
    }
}