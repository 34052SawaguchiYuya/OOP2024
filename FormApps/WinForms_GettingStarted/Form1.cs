using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using Microsoft.Web.WebView2.Core;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms_GettingStarted {
    public partial class Form1 : Form {
        private Dictionary<string, string> category;
        private List<ItemData> items;
        private List<ItemData> favorites;


        public Form1() {
            InitializeCategories();
            favorites = new List<ItemData>();
        }

        private void InitializeCategories() {
            category = new Dictionary<string, string>
            {
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

        }

        private void btToroku_Click(object sender, EventArgs e) {
            var inputTitle = cbName.Text;
            var inputUrl = cbRssUrl.Text;


            if (string.IsNullOrWhiteSpace(inputTitle) & string.IsNullOrWhiteSpace(inputUrl)) {
                MessageBox.Show("URLを入力してください。");
                return;
            }


            var newItem = new ItemData { Title = inputTitle, Link = inputUrl };
            if (!favorites.Any(f => f.Title == newItem.Title && f.Link == newItem.Link)) {
                favorites.Add(newItem);


                if (!category.ContainsKey(inputTitle)) {
                    category.Add(inputTitle, inputUrl);
                    cbRssUrl.Items.Add(inputTitle);
                }


                if (!cbName.Items.Contains(inputTitle)) {
                    cbName.Items.Add(inputTitle);
                }

                MessageBox.Show("お気に入り");
            } else {
                MessageBox.Show("すでにしてあります。");
            }
        }

        private void cbRssUrl_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (cbRssUrl.SelectedItem == null)
                return;
        }

        private void LoadRssFeed(string selectedCategory) {
            lbRssTitle.Items.Clear();

            if (category.TryGetValue(selectedCategory, out var rssUrl)) {

                using (var wc = new WebClient()) {
                    var data = wc.OpenRead(rssUrl);
                    var xdoc = XDocument.Load(data);

                    items = xdoc.Root.Descendants("item")
                        .Select(item => new ItemData {
                            Title = item.Element("title").Value,
                            Link = item.Element("link").Value
                        }).ToList();

                    foreach (var item in items) {
                        lbRssTitle.Items.Add(item.Title);
                    }
                }
            } else {
                MessageBox.Show("URLがない");
            }
        }



        private void btdelete_Click_1(object sender, EventArgs e) {
            if (cbName.SelectedItem != null) {
                var selectedTitle = cbName.SelectedItem.ToString();
                var itemToDelete = favorites.FirstOrDefault(f => f.Title == selectedTitle);


                if (itemToDelete != null) {
                    favorites.Remove(itemToDelete);
                    cbName.Items.Remove(selectedTitle);

                    MessageBox.Show($"「{selectedTitle}」をお気に入りから削除しました。");
                }
                } else {
                    MessageBox.Show("選択されたアイテムはお気に入りに存在しません。");
                }
                cbName.Text = cbName.Text.Trim();
            }

            public class ItemData {
            public string Title { get; set; }
            public string Link { get; set; }

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void webView21_Click(object sender, EventArgs e) {

        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }

}
