using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace MangaReader
{
    class Scraper
    {
        public static void ProcessPage(String url)
        {
            String mangaId = url.Substring(url.LastIndexOf('/')+1);
            var html = GetHtmlFromPage(url);
            var links = ExtractLinks(html);
            links = FilterLinks(links, mangaId);
            foreach (String link in links)
            {
                Console.WriteLine(link);
            }
        }

        private static HtmlDocument GetHtmlFromPage(String url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            return htmlDoc;
        }

        private static List<String> ExtractLinks(HtmlDocument htmlDoc)
        {
            List<String> links = new List<string>();
            foreach (HtmlNode link in htmlDoc.DocumentNode.SelectNodes("//a[@href]"))
            {
                links.Add(link.GetAttributeValue("href", null));
            }
            return links;
        }

        private static List<String> FilterLinks(List<String> links, String mangaId)
        {
            List<String> filteredLinks = new List<string>();
            Regex chapterRegex = new Regex(@"^https://manganelo.com/chapter/"+mangaId+"/.*$", RegexOptions.IgnoreCase);
            foreach (String link in links)
            {
                if (chapterRegex.IsMatch(link))
                {
                    filteredLinks.Add(link);
                }
            }
            return filteredLinks;
        }
    }
}
