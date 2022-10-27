namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmAltaCliente
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
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTituloAltaCliente = new System.Windows.Forms.Label();
            this.gboNombre = new System.Windows.Forms.GroupBox();
            this.gboDireccion = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.gboDatosPersonales = new System.Windows.Forms.GroupBox();
            this.gboNombre.SuspendLayout();
            this.gboDireccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gboDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(153, 112);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(220, 24);
            this.cboBarrio.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(769, 315);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(527, 315);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(153, 69);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(220, 22);
            this.txtAltura.TabIndex = 23;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(153, 23);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(220, 22);
            this.txtCalle.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(125, 66);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(212, 22);
            this.txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 22);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 22);
            this.txtNombre.TabIndex = 20;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 116);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(43, 16);
            this.lblBarrio.TabIndex = 19;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(21, 70);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 16);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Apellido";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(20, 73);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(41, 16);
            this.lblAltura.TabIndex = 17;
            this.lblAltura.Text = "Altura";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(20, 27);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(38, 16);
            this.lblCalle.TabIndex = 16;
            this.lblCalle.Text = "Calle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 26);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTituloAltaCliente
            // 
            this.lblTituloAltaCliente.AutoSize = true;
            this.lblTituloAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAltaCliente.Location = new System.Drawing.Point(35, 30);
            this.lblTituloAltaCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloAltaCliente.Name = "lblTituloAltaCliente";
            this.lblTituloAltaCliente.Size = new System.Drawing.Size(198, 31);
            this.lblTituloAltaCliente.TabIndex = 14;
            this.lblTituloAltaCliente.Text = "Nuevo Cliente";
            // 
            // gboNombre
            // 
            this.gboNombre.Controls.Add(this.lblNombre);
            this.gboNombre.Controls.Add(this.txtApellido);
            this.gboNombre.Controls.Add(this.lblPrecio);
            this.gboNombre.Controls.Add(this.txtNombre);
            this.gboNombre.Location = new System.Drawing.Point(12, 23);
            this.gboNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboNombre.Name = "gboNombre";
            this.gboNombre.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboNombre.Size = new System.Drawing.Size(429, 148);
            this.gboNombre.TabIndex = 27;
            this.gboNombre.TabStop = false;
            // 
            // gboDireccion
            // 
            this.gboDireccion.Controls.Add(this.cboBarrio);
            this.gboDireccion.Controls.Add(this.lblCalle);
            this.gboDireccion.Controls.Add(this.lblAltura);
            this.gboDireccion.Controls.Add(this.txtCalle);
            this.gboDireccion.Controls.Add(this.lblBarrio);
            this.gboDireccion.Controls.Add(this.txtAltura);
            this.gboDireccion.Location = new System.Drawing.Point(461, 23);
            this.gboDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDireccion.Name = "gboDireccion";
            this.gboDireccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDireccion.Size = new System.Drawing.Size(417, 148);
            this.gboDireccion.TabIndex = 28;
            this.gboDireccion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoCliente);
            this.groupBox1.Controls.Add(this.lblTipoCliente);
            this.groupBox1.Location = new System.Drawing.Point(16, 282);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(429, 86);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(160, 36);
            this.cboTipoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(220, 24);
            this.cboTipoCliente.TabIndex = 26;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(27, 39);
            this.lblTipoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(98, 16);
            this.lblTipoCliente.TabIndex = 16;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // gboDatosPersonales
            // 
            this.gboDatosPersonales.Controls.Add(this.gboNombre);
            this.gboDatosPersonales.Controls.Add(this.gboDireccion);
            this.gboDatosPersonales.Location = new System.Drawing.Point(4, 75);
            this.gboDatosPersonales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDatosPersonales.Name = "gboDatosPersonales";
            this.gboDatosPersonales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboDatosPersonales.Size = new System.Drawing.Size(899, 187);
            this.gboDatosPersonales.TabIndex = 27;
            this.gboDatosPersonales.TabStop = false;
            this.gboDatosPersonales.Text = "Datos personales";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 389);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTituloAltaCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboDatosPersonales);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAltaCliente";
            this.Text = "FrmAltaCliente";
            this.Load += new System.EventHandler(this.FrmAltaCliente_Load);
            this.gboNombre.ResumeLayout(false);
            this.gboNombre.PerformLayout();
            this.gboDireccion.ResumeLayout(false);
            this.gboDireccion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboDatosPersonales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTituloAltaCliente;
        private System.Windows.Forms.GroupBox gboNombre;
        private System.Windows.Forms.GroupBox gboDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.GroupBox gboDatosPersonales;
    }
}