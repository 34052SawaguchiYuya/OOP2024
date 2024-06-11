using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCounter {
    public class SalesCounter {
        private List<Sale> _sales;

        public static string ShopName { get; private set; }

        //コンストラクタ
        public SalesCounter(string filePass) {
            _sales = ReadSales(filePass);
        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale();
                ShopName = items[0];
            }
        }

        private static IDictionary<string, int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName)) {
                    dict[sale.ShopName] += sale.Amount;
                } else {
                    dict[sale.ShopName] = sale.Amount;
                }
            }
            return dict;
        }
    }
}

