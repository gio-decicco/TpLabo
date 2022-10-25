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
            this.viscantidadytotalxclienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSPrimerConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSPrimerConsulta();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vis_cantidadytotal_x_clienteTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSPrimerConsultaTableAdapters.vis_cantidadytotal_x_clienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viscantidadytotalxclienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPrimerConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // viscantidadytotalxclienteBindingSource
            // 
            this.viscantidadytotalxclienteBindingSource.DataMember = "vis_cantidadytotal_x_cliente";
            this.viscantidadytotalxclienteBindingSource.DataSource = this.dSPrimerConsulta;
            // 
            // dSPrimerConsulta
            // 
            this.dSPrimerConsulta.DataSetName = "DSPrimerConsulta";
            this.dSPrimerConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSPrimerConsulta";
            reportDataSource1.Value = this.viscantidadytotalxclienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.ListadoConsulta1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // vis_cantidadytotal_x_clienteTableAdapter
            // 
            this.vis_cantidadytotal_x_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporte1";
            this.Text = "FrmReporte1";
            this.Load += new System.EventHandler(this.FrmReporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viscantidadytotalxclienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSPrimerConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSPrimerConsulta dSPrimerConsulta;
        private System.Windows.Forms.BindingSource viscantidadytotalxclienteBindingSource;
        private DataSets.DSPrimerConsultaTableAdapters.vis_cantidadytotal_x_clienteTableAdapter vis_cantidadytotal_x_clienteTableAdapter;
    }
}