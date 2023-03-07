namespace UserInterface
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.leftPanelMain = new System.Windows.Forms.Panel();
            this.rightPanelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // leftPanelMain
            // 
            this.leftPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelMain.Location = new System.Drawing.Point(0, 0);
            this.leftPanelMain.Name = "leftPanelMain";
            this.leftPanelMain.Size = new System.Drawing.Size(268, 761);
            this.leftPanelMain.TabIndex = 1;
            // 
            // rightPanelMain
            // 
            this.rightPanelMain.BackColor = System.Drawing.Color.White;
            this.rightPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanelMain.Location = new System.Drawing.Point(268, 0);
            this.rightPanelMain.Name = "rightPanelMain";
            this.rightPanelMain.Size = new System.Drawing.Size(1016, 761);
            this.rightPanelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.rightPanelMain);
            this.Controls.Add(this.leftPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "MainForm";
            this.Text = "UserManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel leftPanelMain;
        private System.Windows.Forms.Panel rightPanelMain;

        public System.Windows.Forms.Panel LeftPanelMain => leftPanelMain;

        public System.Windows.Forms.Panel RightPanelMain => rightPanelMain;
    }
}