namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmReporte1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSListado = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSListado();
            this.dTVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTVistaTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSListadoTableAdapters.DTVistaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSVista";
            reportDataSource1.Value = this.dTVistaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.ListadoConsulta1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSListadoBindingSource
            // 
            this.dSListadoBindingSource.DataSource = this.dSListado;
            this.dSListadoBindingSource.Position = 0;
            // 
            // dSListado
            // 
            this.dSListado.DataSetName = "DSListado";
            this.dSListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTVistaBindingSource
            // 
            this.dTVistaBindingSource.DataMember = "DTVista";
            this.dTVistaBindingSource.DataSource = this.dSListado;
            // 
            // dTVistaTableAdapter
            // 
            this.dTVistaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte1";
            this.Text = "FrmReporte1";
            this.Load += new System.EventHandler(this.FrmReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVistaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSListadoBindingSource;
        private DataSets.DSListado dSListado;
        private System.Windows.Forms.BindingSource dTVistaBindingSource;
        private DataSets.DSListadoTableAdapters.DTVistaTableAdapter dTVistaTableAdapter;
    }
}