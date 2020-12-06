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
    public partial class MangaTableRow : UserControl
    {
        public PictureBox cover;
        public Label title;
        public Label unread;
        public Color backgroundColor;
        public Manga manga;

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks the delete context menu item for a manga table row")]
        public event EventHandler contextDeleteClick;
        public MangaTableRow()
        {
            InitializeComponent();
            this.cover = imgCover;
            this.title = lblTitle;
            this.unread = lblUnread;
            lblTitle.ForeColor = Control.DefaultForeColor;
            this.backgroundColor = this.BackColor;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextDeleteClick?.Invoke(this, e);
        }

        public void SetAllClicks(EventHandler eventHandler, Control parent = null)
        {
            if (parent is null)
            {
                parent = this;
            }
            parent.Click += eventHandler;
            foreach (Control childControl in parent.Controls)
            {
                SetAllClicks(eventHandler, childControl);  
            }
            
        }
    }
}
