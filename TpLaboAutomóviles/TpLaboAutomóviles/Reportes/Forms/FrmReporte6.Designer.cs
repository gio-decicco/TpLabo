namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmReporte6
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
            this.dT6taConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSextaConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSextaConsulta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dT6taConsultaTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSextaConsultaTableAdapters.DT6taConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dT6taConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSextaConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dT6taConsultaBindingSource
            // 
            this.dT6taConsultaBindingSource.DataMember = "DT6taConsulta";
            this.dT6taConsultaBindingSource.DataSource = this.dSSextaConsulta;
            // 
            // dSSextaConsulta
            // 
            this.dSSextaConsulta.DataSetName = "DSSextaConsulta";
            this.dSSextaConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSSextaConsulta";
            reportDataSource1.Value = this.dT6taConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.SextaConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(807, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // dT6taConsultaTableAdapter
            // 
            this.dT6taConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReporte6";
            this.Text = "FrmReporte6";
            this.Load += new System.EventHandler(this.FrmReporte6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dT6taConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSextaConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSSextaConsulta dSSextaConsulta;
        private System.Windows.Forms.BindingSource dT6taConsultaBindingSource;
        private DataSets.DSSextaConsultaTableAdapters.DT6taConsultaTableAdapter dT6taConsultaTableAdapter;
    }
}