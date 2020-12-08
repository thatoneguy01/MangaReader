using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaReader
{
    public partial class ReaderForm : Form
    {
        private MangaTableRow selectedRow;

        public ReaderForm()
        {
            InitializeComponent();
        }
        
        private MangaTableRow GetMangaTableRowWithManga(Manga m)
        {
            foreach (Control c in tblFavManga.Controls)
            {
                if (!(c is MangaTableRow))
                {
                    continue;
                }
                if (((MangaTableRow)c).manga == m)
                {
                    return ((MangaTableRow)c);
                }
            }
            return null;
        }

        private MangaTableRow CreateTableRowPanelFromManga(DataManager dm, Manga m)
        {
            var rowContents = new MangaTableRow();
            rowContents.Dock = DockStyle.Fill;
            rowContents.cover.Image = Utils.ResizeImage(Image.FromFile(dm.ImgPathForMangaId(m.id)), 53, 70);
            rowContents.title.Text = m.title;
            rowContents.manga = m;
            /*if (m.chapters.Any(chap => !chap.read))
            {
                rowContents.unread.Visible = true;
            }
            else
            {
                rowContents.unread.Visible = false;
            }*/
            rowContents.SetAllClicks(new EventHandler(MangaTableRow_Clicked));
            return rowContents;
        }

        private void MangaReader_Load(object sender, EventArgs e)
        {
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
                MangaTableRow rowContents = CreateTableRowPanelFromManga(dm, m);
                /*if (rowContents.manga.chapters.Any(ch => !ch.read))
                {
                    rowContents.unread.Enabled = true;
                    rowContents.unread.Visible = true;
                }*/
                rows.Add(rowContents);
            }
            var sortedRows = (from row in rows orderby !row.unread.Visible, row.title.Text select row).ToList();
            foreach (MangaTableRow row in sortedRows)
            {
                AddFavMangaTableRow(row);
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            var progress = new Progress<ProgressData>(data =>
            {
                data.mangaRow.unread.Visible = true;
                data.beforeManga.chapters.Insert(data.insertIndex, data.newChapter);
            });
            await Task.Factory.StartNew(() => this.WorkerRefresh_DoWork(progress),
                                TaskCreationOptions.LongRunning);
            this.selectedRow?.manga.PopulateListBox(listChapter);
        }

        public partial class ProgressData 
        {
            public MangaTableRow mangaRow;
            public Manga beforeManga;
            public Chapter newChapter;
            public int insertIndex;

            public ProgressData(MangaTableRow mangaRow, Manga beforeManga, Chapter newChapter, int insertIndex)
            {
                this.mangaRow = mangaRow;
                this.beforeManga = beforeManga;
                this.newChapter = newChapter;
                this.insertIndex = insertIndex;
            }
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerAddFav.IsBusy)
            {
                backgroundWorkerAddFav.RunWorkerAsync();
            }
        }

        private void WorkerRefresh_DoWork(IProgress<ProgressData> progress)
        {
            DataManager dm = new DataManager();
            var favUrls = dm.GetFavoritesUrls();
            Task[] tasks = new Task[favUrls.Count];
            int taskNum = 0;
            foreach (String url in favUrls)
            {
                tasks[taskNum++] = Task.Factory.StartNew(() => this.RefreshThreadWork(url, progress));
            }
            Task.WaitAll(tasks);
        }

        private void RefreshThreadWork(String url, IProgress<ProgressData> progress)
        {
            //String url = objUrl as String;
            DataManager dm = new DataManager();
            var chapters = Scraper.GetChapterUrls(url);
            var beforeManga = dm.FavoriteWithUrl(url);
            var chapUrls = new List<String>();
            chapUrls.AddRange(beforeManga.chapters.Select(ch => ch.url));
            MangaTableRow mangaRow = GetMangaTableRowWithManga(beforeManga);
            int inserted = 0;
            foreach (String chapterUrl in chapters)
            {
                if (!chapUrls.Contains(chapterUrl))
                {
                    Chapter newChapter = new Chapter(chapterUrl, false);
                    //beforeManga.chapters.Insert(inserted++, newChapter);
                    //mangaRow.manga.chapters.Insert(0, newChapter);
                    progress.Report(new ProgressData(mangaRow, mangaRow.manga, newChapter, inserted++));
                }
            }
        }

        private void backgroundWorkerAddFav_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Uri.IsWellFormedUriString(txtbxAddFav.Text, UriKind.Absolute) && txtbxAddFav.Text.StartsWith(@"https://manganelo.com/manga/"))
            {
                var manga = new Manga(txtbxAddFav.Text);
                var dm = new DataManager();
                dm.AddFavorite(manga);
                var tableRow = CreateTableRowPanelFromManga(dm, manga);
                AddFavMangaTableRow(tableRow);

            }
            else
            {
                Application.Run(new BadUrlPopup());
            }
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
            if (!(this.selectedRow is null))
            {
                selectedRow.SetAllBackgroundColor(SystemColors.Window);
            }
            selectedRow = clickedRow;
            clickedRow.SetAllBackgroundColor(SystemColors.ControlDark);
            listChapter.Items.Clear();
            clickedRow.manga.PopulateListBox(listChapter);
        }

        public void MangaTableRow_ContextDeleteClicked(object sender, EventArgs e)
        {
            MangaTableRow rowToDelete = (MangaTableRow)sender;
            DataManager dm = new DataManager();
            dm.RemoveFavorite(rowToDelete.manga.title);
            MangaReader_Load(null, null);
        }

        private void listChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (ListBox)sender;
            if (selected.SelectedItem is null)
            {
                return;
            }
            var chapForSelected = selectedRow.manga.chapters.Where(ch => ch.name == selected.SelectedItem.ToString().Replace("***", "")).FirstOrDefault();
            chapForSelected.PopulateReader(panelReader);
            if (!chapForSelected.read)
            {
                chapForSelected.read = true;
                int index = selected.SelectedIndex;
                selected.Items[index] = selected.Text.Replace("***", "");
                selected.SelectedIndex = index;
                if (selectedRow.manga.chapters.All(ch => ch.read))
                {
                    selectedRow.unread.Visible = false;
                }
            }
            
        }

        private void ReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager dm = new DataManager();
            dm.SaveFavorites();
        }

        private void splitContainer3_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void txtbxAddFav_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddFav_Click(null, null);
            }
        }
    }
}
