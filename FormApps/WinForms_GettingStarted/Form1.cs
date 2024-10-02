using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForms_GettingStarted {

    public partial class Form1 : Form {
        List<ItemData> items;
        Dictionary<string, string> dic;
        Dictionary<string, string> favoriteUrls;

        List<string> favoriteTitles;

        private string currentUrl;

        public Form1() {
            InitializeComponent();
            dic = new Dictionary<string, string>() {
                {"国内","https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                {"国際","https://news.yahoo.co.jp/rss/topics/world.xml"},
                {"経済","https://news.yahoo.co.jp/rss/topics/business.xml"},
                {"エンタメ","https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
                {"スポーツ","https://news.yahoo.co.jp/rss/topics/sports.xml"},
                {"IT","https://news.yahoo.co.jp/rss/topics/it.xml"},
                {"科学","https://news.yahoo.co.jp/rss/topics/science.xml"},
                {"地域","https://news.yahoo.co.jp/rss/topics/local.xml"},
            };

            favoriteTitles = new List<string>();
            favoriteUrls = new Dictionary<string, string>();
        }



        private void tbRssUrl_TextChanged(object sender, EventArgs e) {
            string url;
            if (dic.TryGetValue(cbRssUrl.Text, out url)) {
                currentUrl = url;

                using (var wc = new WebClient()) {
                    var rssUrl = wc.OpenRead(url);
                    var xdoc = XDocument.Load(rssUrl);

                }
            }
        }

        private void btGet_Click(object sender, EventArgs e) {
            string url;
            if (dic.TryGetValue(cbRssUrl.Text, out url)) {
                //URLの保存
                currentUrl = url;

                using (var wc = new WebClient()) {
                    var rssUrl = wc.OpenRead(url);
                    var xdoc = XDocument.Load(rssUrl);

                    items = xdoc.Root.Descendants("item")
                        .Select(item => new ItemData {
                            Title = item.Element("title").Value,
                            Link = item.Element("link").Value
                        }).ToList();

                }
            } else {
                MessageBox.Show("見つかりません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void webBrowser1_Click(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (webBrowser1 != null && webBrowser1 != null) {
                Console.WriteLine("URLが表示されていない。");
            } else {
                Console.WriteLine("");
            }
        }




        //データ格納用のクラス
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
    }
}