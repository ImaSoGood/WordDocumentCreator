﻿namespace Konstructor
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bDDDataSet = new Konstructor.BDDDataSet();
            this.bDDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitulBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TitulTableAdapter = new Konstructor.BDDDataSetTableAdapters.TitulTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitulBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TitulBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Konstructor.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDDDataSet
            // 
            this.bDDDataSet.DataSetName = "BDDDataSet";
            this.bDDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDDataSetBindingSource
            // 
            this.bDDDataSetBindingSource.DataSource = this.bDDDataSet;
            this.bDDDataSetBindingSource.Position = 0;
            // 
            // TitulBindingSource
            // 
            this.TitulBindingSource.DataMember = "Titul";
            this.TitulBindingSource.DataSource = this.bDDDataSet;
            // 
            // TitulTableAdapter
            // 
            this.TitulTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitulBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bDDDataSetBindingSource;
        private BDDDataSet bDDDataSet;
        private System.Windows.Forms.BindingSource TitulBindingSource;
        private BDDDataSetTableAdapters.TitulTableAdapter TitulTableAdapter;
    }
}