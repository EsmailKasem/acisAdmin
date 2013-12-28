namespace FrameWork
{
    partial class AcisStatusBar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_RecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_RecordCount_Dt = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Mode_Dt = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Lang = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_Language_Dt = new System.Windows.Forms.ToolStripStatusLabel();
            this.Prog_Status = new System.Windows.Forms.ToolStripProgressBar();
            this.Lbl_UserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.Lbl_UserName_Dt = new System.Windows.Forms.ToolStripStatusLabel();
           // this.SuspendLayout();

            // 
            // statusStrip1
            // 

            // 
            // Lbl_RecordCount
            // 
            this.Lbl_RecordCount.AutoSize = false;
            this.Lbl_RecordCount.Name = "Lbl_RecordCount";
            this.Lbl_RecordCount.Size = new System.Drawing.Size(100, 19);
            this.Lbl_RecordCount.Text = "Record Count";
            // 
            // Lbl_RecordCount_Dt
            // 
            this.Lbl_RecordCount_Dt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl_RecordCount_Dt.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_RecordCount_Dt.Name = "Lbl_RecordCount_Dt";
            this.Lbl_RecordCount_Dt.Size = new System.Drawing.Size(25, 19);
            this.Lbl_RecordCount_Dt.Text = "114";
            // 
            // Lbl_Mode
            // 
            this.Lbl_Mode.AutoSize = false;
            this.Lbl_Mode.Name = "Lbl_Mode";
            this.Lbl_Mode.Size = new System.Drawing.Size(60, 19);
            this.Lbl_Mode.Text = "Mode";
            // 
            // Lbl_Mode_Dt
            // 
            this.Lbl_Mode_Dt.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.Lbl_Mode_Dt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl_Mode_Dt.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Mode_Dt.Name = "Lbl_Mode_Dt";
            this.Lbl_Mode_Dt.Size = new System.Drawing.Size(61, 19);
           // this.Lbl_Mode_Dt.Text = "Read Only";
            // 
            // Lbl_Lang
            // 
            this.Lbl_Lang.AutoSize = false;
            this.Lbl_Lang.Image = global::FrameWork.Properties.Resources._1376845933_keyboard;
            this.Lbl_Lang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Lang.Name = "Lbl_Lang";
            this.Lbl_Lang.Size = new System.Drawing.Size(30, 19);
            this.Lbl_Lang.Tag = "       ";
            // 
            // Lbl_Language_Dt
            // 
            this.Lbl_Language_Dt.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.Lbl_Language_Dt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Lbl_Language_Dt.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Language_Dt.Name = "Lbl_Language_Dt";
            this.Lbl_Language_Dt.Size = new System.Drawing.Size(22, 19);
            this.Lbl_Language_Dt.Text = "AR";
            // 
            // Prog_Status
            // 
            this.Prog_Status.MarqueeAnimationSpeed = 10;
            this.Prog_Status.Name = "Prog_Status";
            this.Prog_Status.Size = new System.Drawing.Size(100, 18);
            this.Prog_Status.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Prog_Status.Visible = false;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.Image = global::FrameWork.Properties.Resources._1376844452_user;
            this.Lbl_UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(389, 19);
            this.Lbl_UserName.Spring = true;
            this.Lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_UserName.ToolTipText = "User Name";
            // 
            // Lbl_UserName_Dt
            // 
            this.Lbl_UserName_Dt.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.Lbl_UserName_Dt.ForeColor = System.Drawing.Color.Black;
            this.Lbl_UserName_Dt.LinkColor = System.Drawing.Color.Black;
            this.Lbl_UserName_Dt.Name = "Lbl_UserName_Dt";
            this.Lbl_UserName_Dt.Size = new System.Drawing.Size(41, 19);
            this.Lbl_UserName_Dt.Text = "Esmail";
            // 
            // AcisStatusBar
            // 
            // this.Controls.Add(this.statusStrip1);
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_RecordCount,
            this.Lbl_RecordCount_Dt,
            this.Lbl_Mode,
            this.Lbl_Mode_Dt,
            this.Lbl_Lang,
            this.Lbl_Language_Dt,
            this.Prog_Status,
            this.Lbl_UserName,
            this.Lbl_UserName_Dt});
            // this.Location = new System.Drawing.Point(0, -2);
            this.Size = new System.Drawing.Size(743, 24);
            //this.TabIndex = 0;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftChanged += new System.EventHandler(this.statusStrip1_RightToLeftChanged);
            this.Name = "AcisStatusBar";
            this.Size = new System.Drawing.Size(743, 22);
            //this.ResumeLayout(false);
            //this.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
           
        }

        #endregion

        //  private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_RecordCount;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_RecordCount_Dt;
        private System.Windows.Forms.ToolStripProgressBar Prog_Status;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_UserName;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_UserName_Dt;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Mode;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Mode_Dt;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Lang;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Language_Dt;
    }
}
