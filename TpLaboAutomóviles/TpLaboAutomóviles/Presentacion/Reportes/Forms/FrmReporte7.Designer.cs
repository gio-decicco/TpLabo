namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmReporte7
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
            this.dSSeptimaConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSeptimaConsulta();
            this.dTClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTClientesTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSeptimaConsultaTableAdapters.DTClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSSeptimaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSSeptimaConsulta";
            reportDataSource1.Value = this.dTClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.SeptimaConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSSeptimaConsulta
            // 
            this.dSSeptimaConsulta.DataSetName = "DSSeptimaConsulta";
            this.dSSeptimaConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTClientesBindingSource
            // 
            this.dTClientesBindingSource.DataMember = "DTClientes";
            this.dTClientesBindingSource.DataSource = this.dSSeptimaConsulta;
            // 
            // dTClientesTableAdapter
            // 
            this.dTClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte7";
            this.Text = "FrmReporte7";
            this.Load += new System.EventHandler(this.FrmReporte7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSSeptimaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSSeptimaConsulta dSSeptimaConsulta;
        private System.Windows.Forms.BindingSource dTClientesBindingSource;
        private DataSets.DSSeptimaConsultaTableAdapters.DTClientesTableAdapter dTClientesTableAdapter;
    }
}