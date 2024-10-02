using Microsoft.Toolkit.Forms.UI.Controls;
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

namespace RssReader {

    public partial class Form1 : Form {
        List<ItemData> items;

        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            using (var wc = new WebClient()) {
                var url = wc.OpenRead(tbRssUrl.Text);
                var xdoc = XDocument.Load(url);

                items = xdoc.Root.Descendants("item")
                                    .Select(item => new ItemData {
                                        Title = item.Element("title").Value,
                                        Link = item.Element("link").Value,
                                    }).ToList();

                foreach (var item in items) {
                    lbRssTitle.Items.Add(item.Title);
                }
            }
        }

        private void tbRssUrl_TextChanged(object sender, EventArgs e) {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            if (webBrowser1 != null && webBrowser1 != null) {
                Console.WriteLine("URLが表示されていない。");
            } else {
                Console.WriteLine("");
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
    //データ格納用のクラス
    public class ItemData {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
