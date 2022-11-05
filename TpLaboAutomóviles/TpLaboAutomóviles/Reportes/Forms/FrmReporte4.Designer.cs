namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmReporte4
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSCuartaConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCuartaConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsulta();
            this.dTImporteMensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCuartaConsulta2 = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsulta2();
            this.dTImporteAnualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCuartaConsulta3 = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsulta3();
            this.dTImporteMensualTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsulta2TableAdapters.DTImporteMensualTableAdapter();
            this.dTImporteAnualTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsulta3TableAdapters.DTImporteAnualTableAdapter();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSCuartaConsultaTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTImporteMensualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTImporteAnualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSCuartaConsulta1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            reportDataSource2.Name = "DSCuartaConsulta2";
            reportDataSource2.Value = this.dTImporteMensualBindingSource;
            reportDataSource3.Name = "DSCuartaConsulta3";
            reportDataSource3.Value = this.dTImporteAnualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.CuartaConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSCuartaConsultaBindingSource
            // 
            this.dSCuartaConsultaBindingSource.DataSource = this.dSCuartaConsulta;
            this.dSCuartaConsultaBindingSource.Position = 0;
            // 
            // dSCuartaConsulta
            // 
            this.dSCuartaConsulta.DataSetName = "DSCuartaConsulta";
            this.dSCuartaConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTImporteMensualBindingSource
            // 
            this.dTImporteMensualBindingSource.DataMember = "DTImporteMensual";
            this.dTImporteMensualBindingSource.DataSource = this.dSCuartaConsulta2;
            // 
            // dSCuartaConsulta2
            // 
            this.dSCuartaConsulta2.DataSetName = "DSCuartaConsulta2";
            this.dSCuartaConsulta2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTImporteAnualBindingSource
            // 
            this.dTImporteAnualBindingSource.DataMember = "DTImporteAnual";
            this.dTImporteAnualBindingSource.DataSource = this.dSCuartaConsulta3;
            // 
            // dSCuartaConsulta3
            // 
            this.dSCuartaConsulta3.DataSetName = "DSCuartaConsulta3";
            this.dSCuartaConsulta3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTImporteMensualTableAdapter
            // 
            this.dTImporteMensualTableAdapter.ClearBeforeFill = true;
            // 
            // dTImporteAnualTableAdapter
            // 
            this.dTImporteAnualTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dSCuartaConsultaBindingSource;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte4";
            this.Text = "FrmReporte4";
            this.Load += new System.EventHandler(this.FrmReporte4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTImporteMensualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTImporteAnualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCuartaConsulta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSCuartaConsulta dSCuartaConsulta;
        private System.Windows.Forms.BindingSource dSCuartaConsultaBindingSource;
        private DataSets.DSCuartaConsulta2 dSCuartaConsulta2;
        private System.Windows.Forms.BindingSource dTImporteMensualBindingSource;
        private DataSets.DSCuartaConsulta2TableAdapters.DTImporteMensualTableAdapter dTImporteMensualTableAdapter;
        private DataSets.DSCuartaConsulta3 dSCuartaConsulta3;
        private System.Windows.Forms.BindingSource dTImporteAnualBindingSource;
        private DataSets.DSCuartaConsulta3TableAdapters.DTImporteAnualTableAdapter dTImporteAnualTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSets.DSCuartaConsultaTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}