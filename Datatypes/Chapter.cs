using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaReader
{
    public class Chapter : IEquatable<Chapter>
    {
        public Chapter(string url, bool read)
        {
            this.url = url;
            this.read = read;
            this.name = url.Substring(url.LastIndexOf('/') + 1);
            this.imageContent = Scraper.GetChapterContents(url);
        }

        public string name { get; set; }
        public string url { get; set; }
        public IList<String> imageContent { get; set; }
        public bool read { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Chapter);
        }

        public bool Equals(Chapter other)
        {
            return other != null &&
                   name == other.name &&
                   url == other.url &&
                   EqualityComparer<IList<string>>.Default.Equals(imageContent, other.imageContent) &&
                   read == other.read;
        }

        public override int GetHashCode()
        {
            int hashCode = 97658596;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(url);
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<string>>.Default.GetHashCode(imageContent);
            hashCode = hashCode * -1521134295 + read.GetHashCode();
            return hashCode;
        }
    }
}
