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
        public static IList<String> GetChapterUrls(String url)
        {
            String mangaId = url.Substring(url.LastIndexOf('/')+1);
            var html = GetHtmlFromPage(url);
            var links = ExtractLinks(html);
            links = FilterLinks(links, mangaId);
            foreach (String link in links)
            {
                Console.WriteLine(link);
            }
            return links;
        }

        public static HtmlDocument GetHtmlFromPage(String url)
        {
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(url);
            return htmlDoc;
        }

        private static IList<String> ExtractLinks(HtmlDocument htmlDoc)
        {
            HtmlNodeCollection linkNodes = htmlDoc.DocumentNode.SelectNodes("//a[@href]");
            return linkNodes.Select(node => node.GetAttributeValue("href", null)).ToList();
        }

        private static IList<String> FilterLinks(IList<String> links, String mangaId)
        {
            Regex chapterRegex = new Regex(@"^https://manganelo.com/chapter/"+mangaId+"/.*$", RegexOptions.IgnoreCase);
            return links.Where(link => chapterRegex.IsMatch(link)).ToList();
        }

        public static String GetMangaImage(String url)
        {
            var html = GetHtmlFromPage(url);
            String imgUrl = html.DocumentNode.SelectSingleNode("//span[@class='info-image']/img").GetAttributeValue("src", null);
            return imgUrl;
        }

        public static String GetMangaTitle(String url)
        {
            var html = GetHtmlFromPage(url);
            String title = html.DocumentNode.SelectSingleNode("//div[@class='story-info-right']/h1").InnerText;
            return title;
        }

        public static IList<String> GetChapterContents(String url)
        {
            var html = GetHtmlFromPage(url);
            var imgNodes = html.DocumentNode.SelectSingleNode("//div[@class='container-chapter-reader']").SelectNodes("//img[@src]");
            return imgNodes.Select(node => node.GetAttributeValue("src", null)).ToList();
        }
    }
}
