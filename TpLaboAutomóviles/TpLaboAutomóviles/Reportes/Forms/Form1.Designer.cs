using Microsoft.ReportingServices;
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;
using TpLaboAutomóviles.Reportes;
using TpLaboAutomóviles.Reportes.DataSet;
using TpLaboAutomóviles.Reportes.Forms;

namespace TpLaboAutomóviles.Reportes.Forms
{
    public partial class Form1
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.visclientebarrioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TpLaboAutomóviles.Reportes.DataSet.DataSet1();
            this.vis_cliente_barrioTableAdapter = new TpLaboAutomóviles.Reportes.DataSet.DataSet1TableAdapters.vis_cliente_barrioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vis_cliente_barrioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visclientebarrioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visclientebarrioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vis_cliente_barrioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visclientebarrioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // visclientebarrioBindingSource
            // 
            this.visclientebarrioBindingSource.DataMember = "vis_cliente_barrio";
            this.visclientebarrioBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vis_cliente_barrioTableAdapter
            // 
            this.vis_cliente_barrioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.visclientebarrioBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Reportes.Diseño.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // vis_cliente_barrioBindingSource
            // 
            this.vis_cliente_barrioBindingSource.DataMember = "vis_cliente_barrio";
            this.vis_cliente_barrioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // visclientebarrioBindingSource1
            // 
            this.visclientebarrioBindingSource1.DataMember = "vis_cliente_barrio";
            this.visclientebarrioBindingSource1.DataSource = this.dataSet1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visclientebarrioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vis_cliente_barrioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visclientebarrioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource visclientebarrioBindingSource;
        private DataSet.DataSet1TableAdapters.vis_cliente_barrioTableAdapter vis_cliente_barrioTableAdapter;
        private ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vis_cliente_barrioBindingSource;
        private System.Windows.Forms.BindingSource visclientebarrioBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
    }
}