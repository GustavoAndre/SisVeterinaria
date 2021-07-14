
namespace Presentacion.reportes
{
    partial class frmReporteCitas
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
            this.cry = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cry
            // 
            this.cry.ActiveViewIndex = -1;
            this.cry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cry.Cursor = System.Windows.Forms.Cursors.Default;
            this.cry.DisplayStatusBar = false;
            this.cry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cry.Location = new System.Drawing.Point(0, 0);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(1153, 465);
            this.cry.TabIndex = 0;
            this.cry.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.cry.Load += new System.EventHandler(this.cry_Load);
            // 
            // frmReporteCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1153, 465);
            this.Controls.Add(this.cry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReporteCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteCitas";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cry;
    }
}