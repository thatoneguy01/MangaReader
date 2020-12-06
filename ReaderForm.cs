using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaReader
{
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();
            if (tblFavManga.RowCount > 0)
            {
                tblFavManga.RowStyles.Clear();
                tblFavManga.Controls.Clear();
                tblFavManga.RowCount = 0;
            }
            DataManager dm = new DataManager();
            var favorites = dm.GetFavorites();
            IList<MangaTableRow> rows = new List<MangaTableRow>();
            foreach (Manga m in favorites)
            {
                MangaTableRow rowContents = TableRowPanelFromManga(dm, m);
                rows.Add(rowContents);
            }
            var sortedRows = (from row in rows orderby !row.unread.Visible, row.title.Text select row).ToList();
            foreach (MangaTableRow row in sortedRows)
            {
                AddFavMangaTableRow(row);
            }
        }

        private MangaTableRow TableRowPanelFromManga(DataManager dm, Manga m)
        {
            var rowContents = new MangaTableRow();
            rowContents.Dock = DockStyle.Fill;
            rowContents.cover.Image = Utils.ResizeImage(Image.FromFile(dm.ImgPathForMangaId(m.id)), 53, 70);
            rowContents.title.Text = m.title;
            rowContents.manga = m;
            if (m.chapters.Any(chap => !chap.read))
            {
                rowContents.unread.Visible = true;
            }
            else
            {
                rowContents.unread.Visible = false;
            }
            rowContents.SetAllClicks(new EventHandler(MangaTableRow_Clicked));
            return rowContents;
        }

        private void MangaReader_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Manga m = new Manga(@"https://manganelo.com/manga/df918379");
            m.PopulateListBox(listChapter);
            listChapter.Items.Add("foobar");
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            if (Uri.IsWellFormedUriString(txtbxAddFav.Text, UriKind.Absolute) && txtbxAddFav.Text.StartsWith(@"https://manganelo.com/manga/"))
            {
                var manga = new Manga(txtbxAddFav.Text);
                var dm = new DataManager();
                dm.AddFavorite(manga);
                var tableRow = TableRowPanelFromManga(dm, manga);
                AddFavMangaTableRow(tableRow);

            }
            else
            {
                Application.Run(new BadUrlPopup());
            }
        }

        private void backgroundWorkerRefresh_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorkerAddFav_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void AddFavMangaTableRow(MangaTableRow row)
        {
            tblFavManga.RowCount = tblFavManga.RowCount + 1;
            tblFavManga.RowStyles.Add(new RowStyle(SizeType.Absolute, 72f));
            tblFavManga.Controls.Add(row, 1, tblFavManga.RowCount - 1);
        }

        private void MangaTableRow_Clicked(object sender, EventArgs e)
        {
            var senderControl = (Control)sender;
            while (!(senderControl is MangaTableRow))
            {
                senderControl = senderControl.Parent;
            }
            MangaTableRow clickedRow = (MangaTableRow)senderControl;
            foreach (Control c in tblFavManga.Controls)
            {
                if (c is MangaTableRow)
                {
                    ((MangaTableRow)c).backgroundColor = SystemColors.Window;
                }
            }
            clickedRow.backgroundColor = SystemColors.ControlLight;
            listChapter.Items.Clear();
            clickedRow.manga.PopulateListBox(listChapter);
        }

        private void MangaTableRow_ContextDeleteClicked(object sender, EventArgs e)
        {
            
        }

        private void listChapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
