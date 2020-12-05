namespace MangaTableRow
{
    partial class MangaTableRow
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imgCover = new System.Windows.Forms.PictureBox();
            this.lblUnread = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imgCover);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblUnread);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitle);
            this.splitContainer1.Size = new System.Drawing.Size(215, 70);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 0;
            // 
            // imgCover
            // 
            this.imgCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCover.Location = new System.Drawing.Point(0, 0);
            this.imgCover.Name = "imgCover";
            this.imgCover.Size = new System.Drawing.Size(53, 70);
            this.imgCover.TabIndex = 0;
            this.imgCover.TabStop = false;
            // 
            // lblUnread
            // 
            this.lblUnread.AutoSize = true;
            this.lblUnread.BackColor = System.Drawing.Color.Transparent;
            this.lblUnread.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUnread.ForeColor = System.Drawing.Color.Red;
            this.lblUnread.Location = new System.Drawing.Point(0, 57);
            this.lblUnread.Name = "lblUnread";
            this.lblUnread.Size = new System.Drawing.Size(93, 13);
            this.lblUnread.TabIndex = 1;
            this.lblUnread.Text = "Unread Chapter(s)";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // MangaTableRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MangaTableRow";
            this.Size = new System.Drawing.Size(215, 70);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox imgCover;
        private System.Windows.Forms.Label lblUnread;
        private System.Windows.Forms.Label lblTitle;
    }
}
