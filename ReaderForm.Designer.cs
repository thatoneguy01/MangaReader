
namespace MangaReader
{
    partial class ReaderForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.txtbxAddFav = new System.Windows.Forms.TextBox();
            this.btnAddFav = new System.Windows.Forms.Button();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panelTblScroll = new System.Windows.Forms.Panel();
            this.tblFavManga = new System.Windows.Forms.TableLayoutPanel();
            this.mangaTableRow1 = new MangaReader.MangaTableRow();
            this.listChapter = new System.Windows.Forms.ListBox();
            this.panelReader = new System.Windows.Forms.Panel();
            this.backgroundWorkerRefresh = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAddFav = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panelTblScroll.SuspendLayout();
            this.tblFavManga.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 577);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(75, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1107, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "MangaReader";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 45);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelReader);
            this.splitContainer2.Size = new System.Drawing.Size(1182, 528);
            this.splitContainer2.SplitterDistance = 399;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(399, 528);
            this.splitContainer3.SplitterDistance = 25;
            this.splitContainer3.TabIndex = 0;
            this.splitContainer3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer3_SplitterMoved);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.txtbxAddFav);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnAddFav);
            this.splitContainer5.Size = new System.Drawing.Size(399, 25);
            this.splitContainer5.SplitterDistance = 350;
            this.splitContainer5.TabIndex = 0;
            // 
            // txtbxAddFav
            // 
            this.txtbxAddFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxAddFav.Location = new System.Drawing.Point(0, 0);
            this.txtbxAddFav.Name = "txtbxAddFav";
            this.txtbxAddFav.Size = new System.Drawing.Size(350, 20);
            this.txtbxAddFav.TabIndex = 0;
            this.txtbxAddFav.Text = "https://manganelo.com/manga/df918379";
            this.txtbxAddFav.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbxAddFav_KeyDown);
            // 
            // btnAddFav
            // 
            this.btnAddFav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFav.Location = new System.Drawing.Point(0, 0);
            this.btnAddFav.Name = "btnAddFav";
            this.btnAddFav.Size = new System.Drawing.Size(45, 25);
            this.btnAddFav.TabIndex = 0;
            this.btnAddFav.Text = "Add";
            this.btnAddFav.UseVisualStyleBackColor = true;
            this.btnAddFav.Click += new System.EventHandler(this.btnAddFav_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.panelTblScroll);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listChapter);
            this.splitContainer4.Size = new System.Drawing.Size(399, 499);
            this.splitContainer4.SplitterDistance = 238;
            this.splitContainer4.TabIndex = 0;
            // 
            // panelTblScroll
            // 
            this.panelTblScroll.AutoScroll = true;
            this.panelTblScroll.Controls.Add(this.tblFavManga);
            this.panelTblScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTblScroll.Location = new System.Drawing.Point(0, 0);
            this.panelTblScroll.Name = "panelTblScroll";
            this.panelTblScroll.Size = new System.Drawing.Size(238, 499);
            this.panelTblScroll.TabIndex = 0;
            // 
            // tblFavManga
            // 
            this.tblFavManga.AutoSize = true;
            this.tblFavManga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFavManga.BackColor = System.Drawing.SystemColors.Window;
            this.tblFavManga.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFavManga.ColumnCount = 1;
            this.tblFavManga.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFavManga.Controls.Add(this.mangaTableRow1, 0, 0);
            this.tblFavManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFavManga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tblFavManga.Location = new System.Drawing.Point(0, 0);
            this.tblFavManga.Name = "tblFavManga";
            this.tblFavManga.RowCount = 1;
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFavManga.Size = new System.Drawing.Size(238, 119);
            this.tblFavManga.TabIndex = 0;
            // 
            // mangaTableRow1
            // 
            this.mangaTableRow1.BackColor = System.Drawing.SystemColors.Window;
            this.mangaTableRow1.CausesValidation = false;
            this.mangaTableRow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mangaTableRow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mangaTableRow1.Location = new System.Drawing.Point(4, 4);
            this.mangaTableRow1.Name = "mangaTableRow1";
            this.mangaTableRow1.Size = new System.Drawing.Size(230, 111);
            this.mangaTableRow1.TabIndex = 0;
            // 
            // listChapter
            // 
            this.listChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listChapter.FormattingEnabled = true;
            this.listChapter.Location = new System.Drawing.Point(0, 0);
            this.listChapter.Name = "listChapter";
            this.listChapter.Size = new System.Drawing.Size(157, 499);
            this.listChapter.TabIndex = 0;
            this.listChapter.SelectedIndexChanged += new System.EventHandler(this.listChapter_SelectedIndexChanged);
            // 
            // panelReader
            // 
            this.panelReader.AutoScroll = true;
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(779, 528);
            this.panelReader.TabIndex = 0;
            // 
            // backgroundWorkerAddFav
            // 
            this.backgroundWorkerAddFav.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAddFav_DoWork);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 583);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReaderForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "MangaReader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderForm_FormClosing);
            this.Load += new System.EventHandler(this.MangaReader_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panelTblScroll.ResumeLayout(false);
            this.panelTblScroll.PerformLayout();
            this.tblFavManga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TextBox txtbxAddFav;
        private System.Windows.Forms.Button btnAddFav;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAddFav;
        private System.Windows.Forms.ListBox listChapter;
        private System.Windows.Forms.Panel panelTblScroll;
        private System.Windows.Forms.TableLayoutPanel tblFavManga;
        private MangaTableRow mangaTableRow1;
        private System.Windows.Forms.Panel panelReader;
    }
}

