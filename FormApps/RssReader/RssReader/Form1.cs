using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {

    public partial class Form1 : Form {

        Dictionary<string, string> rssDict;
        List<ItemData> items;

        public Form1() {
            InitializeComponent();

            rssDict = new Dictionary<string, string> {
                {"主要", "https://news.yahoo.co.jp/rss/topics/top-picks.xml"},
                {"国内", "https://news.yahoo.co.jp/rss/topics/domestic.xml"},
                {"国際", "https://news.yahoo.co.jp/rss/topics/world.xml"},
                {"経済", "https://news.yahoo.co.jp/rss/topics/business.xml"},
                {"エンタメ", "https://news.yahoo.co.jp/rss/topics/entertainment.xml"},
                {"スポーツ", "https://news.yahoo.co.jp/rss/topics/sports.xml"},
                {"IT", "https://news.yahoo.co.jp/rss/topics/it.xml"},
                {"科学", "https://news.yahoo.co.jp/rss/topics/science.xml"},
                {"地域", "https://news.yahoo.co.jp/rss/topics/local.xml"},
            };
            foreach (var item in rssDict.Keys) {
                CbRssUrl.Items.Add(item);
            }

            CbRssUrl.SelectedIndexChanged += CbRssUrl_SelectedIndexChanged;
        }
        
        private void Syutoku_Click(object sender, EventArgs e) {
            if (CbRssUrl.SelectedItem == null)
                return;

            string selectedCategory = CbRssUrl.SelectedItem.ToString();
            string rssUrl = rssDict[selectedCategory];

            using (var wc = new WebClient()) {
                var url = wc.OpenRead(rssUrl);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                    .Select(item => new ItemData {
                        Title = item.Element("title").Value,
                        Link = item.Element("link").Value,
                    }).ToList();

                foreach (var item in items) {
                    ListBox.Items.Add(item.Title);
                }

            }
        }

        private void Touroku_Click(object sender, EventArgs e) {
            Touroku.Enabled = false;

            string favorite = CbRssUrl2.Text.Trim();
            string selectedUrl = CbRssUrl.Text.ToString();

            if (!string.IsNullOrEmpty(favorite) && !string.IsNullOrEmpty(selectedUrl)) {
                CbRssUrl.Items.Add(favorite);
                rssDict[favorite] = selectedUrl;
                MessageBox.Show("登録完了");
            } else {
                MessageBox.Show("名前とURLの両方を入力してください。");
            }
            Touroku.Enabled = true;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (ListBox.SelectedItem != null) { 
                var selectedTitle = ListBox.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);
                if (selectedItem != null) {
                }
            }
        } 

        private void CbRssUrl_SelectedIndexChanged(object sender, EventArgs e) {
            ListBox.Items.Clear();
        }

        private void CbRssUrl2_SelectedIndexChanged(object sender, EventArgs e) {

        }
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
    }
}
