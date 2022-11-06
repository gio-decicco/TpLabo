namespace TpLaboAutomóviles.Reportes.Forms
{
    partial class Form2
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
            this.visfacturastotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new TpLaboAutomóviles.Reportes.DataSet.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vis_facturas_totalTableAdapter = new TpLaboAutomóviles.Reportes.DataSet.DataSet2TableAdapters.vis_facturas_totalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.visfacturastotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // visfacturastotalBindingSource
            // 
            this.visfacturastotalBindingSource.DataMember = "vis_facturas_total";
            this.visfacturastotalBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.visfacturastotalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TpLaboAutomóviles.Reportes.Diseño.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-4, -4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(804, 449);
            this.reportViewer1.TabIndex = 0;
            // 
            // vis_facturas_totalTableAdapter
            // 
            this.vis_facturas_totalTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visfacturastotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource visfacturastotalBindingSource;
        private DataSet.DataSet2TableAdapters.vis_facturas_totalTableAdapter vis_facturas_totalTableAdapter;
    }
}