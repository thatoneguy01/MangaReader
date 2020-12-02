using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaReader
{
    public class Manga
    {
        public string name { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public IList<string> readChapters { get; set; }
        public IList<string> unreadChapters { get; set; }
    }
}
