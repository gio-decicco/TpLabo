namespace TpLaboAutomóviles.Presentacion
{
    partial class FrmReporte2
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
            this.dSSegundaConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DSSegundaConsulta();
            this.dTSegundaConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTSegundaConsultaTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DSSegundaConsultaTableAdapters.DTSegundaConsultaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSSegundaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSegundaConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dTSegundaConsultaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.SegundaConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSSegundaConsulta
            // 
            this.dSSegundaConsulta.DataSetName = "DSSegundaConsulta";
            this.dSSegundaConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTSegundaConsultaBindingSource
            // 
            this.dTSegundaConsultaBindingSource.DataMember = "DTSegundaConsulta";
            this.dTSegundaConsultaBindingSource.DataSource = this.dSSegundaConsulta;
            // 
            // dTSegundaConsultaTableAdapter
            // 
            this.dTSegundaConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte2";
            this.Text = "FrmReporte2";
            this.Load += new System.EventHandler(this.FrmReporte2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSegundaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSegundaConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DSSegundaConsulta dSSegundaConsulta;
        private System.Windows.Forms.BindingSource dTSegundaConsultaBindingSource;
        private Reportes.DSSegundaConsultaTableAdapters.DTSegundaConsultaTableAdapter dTSegundaConsultaTableAdapter;
    }
}