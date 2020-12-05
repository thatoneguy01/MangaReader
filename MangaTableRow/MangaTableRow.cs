using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaTableRow
{
    public partial class MangaTableRow: UserControl
    {
        public PictureBox coverImg;
        public Label title;
        public Label isUnread;
        public MangaTableRow()
        {
            InitializeComponent();
            this.coverImg = imgCover;
            this.title = lblTitle;
            this.isUnread = lblUnread;
        }

    }
}
