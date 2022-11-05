namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmReporte3
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
            this.dSTerceraConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSTerceraConsulta();
            this.dT3erConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT3erConsultaTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSTerceraConsultaTableAdapters.DT3erConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSTerceraConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT3erConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSTercerConsulta";
            reportDataSource1.Value = this.dT3erConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.TercerConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSTerceraConsulta
            // 
            this.dSTerceraConsulta.DataSetName = "DSTerceraConsulta";
            this.dSTerceraConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dT3erConsultaBindingSource
            // 
            this.dT3erConsultaBindingSource.DataMember = "DT3erConsulta";
            this.dT3erConsultaBindingSource.DataSource = this.dSTerceraConsulta;
            // 
            // dT3erConsultaTableAdapter
            // 
            this.dT3erConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte3";
            this.Text = "FrmReporte3";
            this.Load += new System.EventHandler(this.FrmReporte3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSTerceraConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dT3erConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSTerceraConsulta dSTerceraConsulta;
        private System.Windows.Forms.BindingSource dT3erConsultaBindingSource;
        private DataSets.DSTerceraConsultaTableAdapters.DT3erConsultaTableAdapter dT3erConsultaTableAdapter;
    }
}