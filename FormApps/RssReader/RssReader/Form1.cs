using System;
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
                cbRssUrl.Items.Add(item);
            }

            cbRssUrl.SelectedIndexChanged += cbRssUrl_SelectedIndexChanged;
        }

        private void syutoku_Click(object sender, EventArgs e) {
            if (cbRssUrl.SelectedIndex == null)
                return;

            string selectedCategory = cbRssUrl.SelectedItem.ToString();
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
                    listBox.Items.Add(item.Title);
                }
            }
        }

        private void touroku_Click(object sender, EventArgs e) {
            touroku.Enabled = false;

            string favorite = cbRssUrl2.Text.Trim();
            string selectedUrl = cbRssUrl.Text.ToString();

            if (!string.IsNullOrEmpty(favorite) && !string.IsNullOrEmpty(selectedUrl)) {
                cbRssUrl.Items.Add(favorite);
                rssDict[favorite] = selectedUrl;
                MessageBox.Show("登録完了");
            } else {
                MessageBox.Show("名前とURLの両方を入力してください。");
            }
            touroku.Enabled = true;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbRssUrl.SelectedIndex != null) {
                var selectedTitle = listBox.SelectedItem.ToString();
                var selectedItem = items.FirstOrDefault(item => item.Title == selectedTitle);
                if (selectedItem != null) {
                }
            }
        }

        private void cbRssUrl_SelectedIndexChanged(object sender, EventArgs e) {
            listBox.Items.Clear();
        }

        private void cbRssUrl2_SelectedIndexChanged(object sender, EventArgs e) {

        }
        public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }
        }
    }
}
