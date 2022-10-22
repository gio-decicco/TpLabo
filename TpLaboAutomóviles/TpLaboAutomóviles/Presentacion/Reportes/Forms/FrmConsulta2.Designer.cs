namespace TpLaboAutomóviles.Presentacion.Reportes.Forms
{
    partial class FrmConsulta2
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
            this.dTSegConsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSSegundaConsulta = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSegundaConsulta();
            this.dTVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSListado = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSListado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTSegConsTableAdapter = new TpLaboAutomóviles.Presentacion.Reportes.DataSets.DSSegundaConsultaTableAdapters.DTSegConsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dTSegConsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSegundaConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dTSegConsBindingSource
            // 
            this.dTSegConsBindingSource.DataMember = "DTSegCons";
            this.dTSegConsBindingSource.DataSource = this.dSSegundaConsulta;
            // 
            // dSSegundaConsulta
            // 
            this.dSSegundaConsulta.DataSetName = "DSSegundaConsulta";
            this.dSSegundaConsulta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTVistaBindingSource
            // 
            this.dTVistaBindingSource.DataMember = "DTVista";
            this.dTVistaBindingSource.DataSource = this.dSListado;
            // 
            // dSListado
            // 
            this.dSListado.DataSetName = "DSListado";
            this.dSListado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSSegundaConsulta2";
            reportDataSource1.Value = this.dTSegConsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Presentacion.Reportes.RDLCs.SegundaConsulta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dTSegConsTableAdapter
            // 
            this.dTSegConsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmConsulta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmConsulta2";
            this.Text = "FrmConsulta2";
            this.Load += new System.EventHandler(this.FrmConsulta2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTSegConsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSegundaConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTVistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DSListado dSListado;
        private System.Windows.Forms.BindingSource dTVistaBindingSource;
        private DataSets.DSSegundaConsulta dSSegundaConsulta;
        private System.Windows.Forms.BindingSource dTSegConsBindingSource;
        private DataSets.DSSegundaConsultaTableAdapters.DTSegConsTableAdapter dTSegConsTableAdapter;
    }
}