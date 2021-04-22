
namespace CapaPresentacion
{
    partial class Reporte
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport2 = new CapaPresentacion.CrystalReport();
            this.CrystalReport1 = new CapaPresentacion.CrystalReport();
            this.CrystalReport3 = new CapaPresentacion.CrystalReport();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport3;
            this.crystalReportViewer1.Size = new System.Drawing.Size(995, 487);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Reporte
            // 
            this.ClientSize = new System.Drawing.Size(995, 487);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Reporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalReport CrystalReport2;
        private CrystalReport CrystalReport1;
        private CrystalReport CrystalReport3;
    }
}