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
            this.cboAutoPlan = new System.Windows.Forms.ComboBox();
            this.cboTipoCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblTipoAutoPlan = new System.Windows.Forms.Label();
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
            this.cboBarrio.Location = new System.Drawing.Point(115, 91);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(166, 21);
            this.cboBarrio.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(410, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(191, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(115, 56);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(166, 20);
            this.txtAltura.TabIndex = 23;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(115, 19);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(166, 20);
            this.txtCalle.TabIndex = 22;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(94, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(16, 94);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 19;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(16, 57);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(44, 13);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Apellido";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 59);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 17;
            this.lblAltura.Text = "Altura";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(15, 22);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 16;
            this.lblCalle.Text = "Calle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTituloAltaCliente
            // 
            this.lblTituloAltaCliente.AutoSize = true;
            this.lblTituloAltaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAltaCliente.Location = new System.Drawing.Point(26, 24);
            this.lblTituloAltaCliente.Name = "lblTituloAltaCliente";
            this.lblTituloAltaCliente.Size = new System.Drawing.Size(160, 25);
            this.lblTituloAltaCliente.TabIndex = 14;
            this.lblTituloAltaCliente.Text = "Nuevo Cliente";
            // 
            // gboNombre
            // 
            this.gboNombre.Controls.Add(this.lblNombre);
            this.gboNombre.Controls.Add(this.txtApellido);
            this.gboNombre.Controls.Add(this.lblPrecio);
            this.gboNombre.Controls.Add(this.txtNombre);
            this.gboNombre.Location = new System.Drawing.Point(9, 19);
            this.gboNombre.Name = "gboNombre";
            this.gboNombre.Size = new System.Drawing.Size(322, 120);
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
            this.gboDireccion.Location = new System.Drawing.Point(346, 19);
            this.gboDireccion.Name = "gboDireccion";
            this.gboDireccion.Size = new System.Drawing.Size(313, 120);
            this.gboDireccion.TabIndex = 28;
            this.gboDireccion.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboAutoPlan);
            this.groupBox1.Controls.Add(this.cboTipoCliente);
            this.groupBox1.Controls.Add(this.lblTipoCliente);
            this.groupBox1.Controls.Add(this.lblTipoAutoPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 70);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // cboAutoPlan
            // 
            this.cboAutoPlan.FormattingEnabled = true;
            this.cboAutoPlan.Location = new System.Drawing.Point(432, 29);
            this.cboAutoPlan.Name = "cboAutoPlan";
            this.cboAutoPlan.Size = new System.Drawing.Size(191, 21);
            this.cboAutoPlan.TabIndex = 27;
            // 
            // cboTipoCliente
            // 
            this.cboTipoCliente.FormattingEnabled = true;
            this.cboTipoCliente.Location = new System.Drawing.Point(120, 29);
            this.cboTipoCliente.Name = "cboTipoCliente";
            this.cboTipoCliente.Size = new System.Drawing.Size(166, 21);
            this.cboTipoCliente.TabIndex = 26;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(20, 32);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lblTipoCliente.TabIndex = 16;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // lblTipoAutoPlan
            // 
            this.lblTipoAutoPlan.AutoSize = true;
            this.lblTipoAutoPlan.Location = new System.Drawing.Point(353, 32);
            this.lblTipoAutoPlan.Name = "lblTipoAutoPlan";
            this.lblTipoAutoPlan.Size = new System.Drawing.Size(53, 13);
            this.lblTipoAutoPlan.TabIndex = 19;
            this.lblTipoAutoPlan.Text = "Auto Plan";
            // 
            // gboDatosPersonales
            // 
            this.gboDatosPersonales.Controls.Add(this.gboNombre);
            this.gboDatosPersonales.Controls.Add(this.gboDireccion);
            this.gboDatosPersonales.Location = new System.Drawing.Point(3, 61);
            this.gboDatosPersonales.Name = "gboDatosPersonales";
            this.gboDatosPersonales.Size = new System.Drawing.Size(674, 152);
            this.gboDatosPersonales.TabIndex = 27;
            this.gboDatosPersonales.TabStop = false;
            this.gboDatosPersonales.Text = "Datos personales";
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 375);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTituloAltaCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboDatosPersonales);
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
        private System.Windows.Forms.ComboBox cboAutoPlan;
        private System.Windows.Forms.ComboBox cboTipoCliente;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblTipoAutoPlan;
        private System.Windows.Forms.GroupBox gboDatosPersonales;
    }
}