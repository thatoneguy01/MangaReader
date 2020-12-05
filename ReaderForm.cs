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
        }

        private void MangaReader_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var color = mangaTableRow1.title.ForeColor;
            int i = 0;
        }

        private void txtbxAddFav_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorkerRefresh_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorkerAddFav_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
