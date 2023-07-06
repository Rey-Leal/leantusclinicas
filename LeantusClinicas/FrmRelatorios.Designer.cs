namespace LeantusClinicas
{
    partial class FrmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorios));
            this.PessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LeantusClinicasDataSet = new LeantusClinicas.LeantusClinicasDataSet();
            this.crvRelatorios = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.wrvRelatorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PessoasTableAdapter = new LeantusClinicas.LeantusClinicasDataSetTableAdapters.PessoasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeantusClinicasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PessoasBindingSource
            // 
            this.PessoasBindingSource.DataMember = "Pessoas";
            this.PessoasBindingSource.DataSource = this.LeantusClinicasDataSet;
            // 
            // LeantusClinicasDataSet
            // 
            this.LeantusClinicasDataSet.DataSetName = "LeantusClinicasDataSet";
            this.LeantusClinicasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crvRelatorios
            // 
            this.crvRelatorios.ActiveViewIndex = -1;
            this.crvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRelatorios.DisplayGroupTree = false;
            this.crvRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRelatorios.Location = new System.Drawing.Point(0, 0);
            this.crvRelatorios.Name = "crvRelatorios";
            this.crvRelatorios.SelectionFormula = "";
            this.crvRelatorios.Size = new System.Drawing.Size(904, 602);
            this.crvRelatorios.TabIndex = 7;
            this.crvRelatorios.ViewTimeSelectionFormula = "";
            // 
            // wrvRelatorios
            // 
            reportDataSource1.Name = "LeantusClinicasDataSet_Pessoas";
            reportDataSource1.Value = this.PessoasBindingSource;
            this.wrvRelatorios.LocalReport.DataSources.Add(reportDataSource1);
            this.wrvRelatorios.LocalReport.ReportEmbeddedResource = "LeantusClinicas.RptTestes.rdlc";
            this.wrvRelatorios.Location = new System.Drawing.Point(782, 0);
            this.wrvRelatorios.Name = "wrvRelatorios";
            this.wrvRelatorios.Size = new System.Drawing.Size(122, 26);
            this.wrvRelatorios.TabIndex = 8;
            // 
            // PessoasTableAdapter
            // 
            this.PessoasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 602);
            this.Controls.Add(this.wrvRelatorios);
            this.Controls.Add(this.crvRelatorios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(240, 180);
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizador de Relatórios";
            this.Load += new System.EventHandler(this.FrmRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeantusClinicasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRelatorios;
        private Microsoft.Reporting.WinForms.ReportViewer wrvRelatorios;
        private System.Windows.Forms.BindingSource PessoasBindingSource;
        private LeantusClinicasDataSet LeantusClinicasDataSet;
        private LeantusClinicas.LeantusClinicasDataSetTableAdapters.PessoasTableAdapter PessoasTableAdapter;
    }
}