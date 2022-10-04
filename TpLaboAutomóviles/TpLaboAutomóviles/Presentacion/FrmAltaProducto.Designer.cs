namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmAltaProducto
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
            this.lblTituloAltaProd = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.txtDescrpicion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboTipoProd = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTituloAltaProd
            // 
            this.lblTituloAltaProd.AutoSize = true;
            this.lblTituloAltaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAltaProd.Location = new System.Drawing.Point(18, 20);
            this.lblTituloAltaProd.Name = "lblTituloAltaProd";
            this.lblTituloAltaProd.Size = new System.Drawing.Size(180, 25);
            this.lblTituloAltaProd.TabIndex = 0;
            this.lblTituloAltaProd.Text = "Nuevo Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descrpicion";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(20, 131);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(68, 13);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock Actual";
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.Location = new System.Drawing.Point(20, 164);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(73, 13);
            this.lblStockMin.TabIndex = 3;
            this.lblStockMin.Text = "Stock Mínimo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 98);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(20, 202);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(88, 13);
            this.lblTipoProd.TabIndex = 5;
            this.lblTipoProd.Text = "Tipo de producto";
            // 
            // txtDescrpicion
            // 
            this.txtDescrpicion.Location = new System.Drawing.Point(119, 62);
            this.txtDescrpicion.Name = "txtDescrpicion";
            this.txtDescrpicion.Size = new System.Drawing.Size(166, 20);
            this.txtDescrpicion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(119, 95);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(166, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(119, 128);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.Size = new System.Drawing.Size(166, 20);
            this.txtStockActual.TabIndex = 8;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(119, 161);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(166, 20);
            this.txtStockMinimo.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(65, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(197, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboTipoProd
            // 
            this.cboTipoProd.FormattingEnabled = true;
            this.cboTipoProd.Location = new System.Drawing.Point(119, 194);
            this.cboTipoProd.Name = "cboTipoProd";
            this.cboTipoProd.Size = new System.Drawing.Size(166, 21);
            this.cboTipoProd.TabIndex = 13;
            // 
            // FrmAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.cboTipoProd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtStockMinimo);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescrpicion);
            this.Controls.Add(this.lblTipoProd);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStockMin);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloAltaProd);
            this.Name = "FrmAltaProducto";
            this.Text = "FrmAltaProducto";
            this.Load += new System.EventHandler(this.FrmAltaProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAltaProd;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.TextBox txtDescrpicion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboTipoProd;
    }
}