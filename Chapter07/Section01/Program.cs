using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var prefOfficeDict = new Dictionary<string, string>();
            //入力処理
            Console.WriteLine("県庁所在地の登録");
            for (int i = 0; i < 5; i++) {
                //都道府県の入力
                Console.Write("都道府県:");
                String pref = Console.ReadLine();

                //県庁所在地の入力
                Console.Write("県庁所在地:");
                String prefCaptalLocation = Console.ReadLine();

                //既に都道府県が登録されているか？
                if (prefOfficeDict.ContainsKey(pref)) {
                    //登録済み
                    Console.WriteLine("上書きしますか？(Y/N)");
                    if (Console.ReadLine() == "N") {
                        continue;
                    }
                }
                prefOfficeDict[pref] = prefCaptalLocation;
            }
            Console.WriteLine();//改行

            Boolean endFlag = false;    //終了フラグ（無限ループを抜け出す用）
            while (true) {
                switch (menuDisp()) {
                    case "1":
                        //一覧出力処理
                        foreach (var item in prefOfficeDict) {
                            Console.WriteLine("{0}の県庁所在地は{1}です。", item.Key, item.Value);
                        }
                        break;

                    case "2":
                        //検索処理
                        //都道府県の入力
                        Console.Write("都道府県:");
                        String searchPref = Console.ReadLine();
                        Console.WriteLine(searchPref + "の県庁所在地は" + prefOfficeDict[searchPref] + "です");
                        break;

                    case "9":
                        endFlag = true; //終了フラグＯＮ
                        break;
                }
            }
        }
        //メニュー表示
        private static string menuDisp() {
            Console.WriteLine("**** メニュー ****");
            Console.WriteLine("1：一覧表示");
            Console.WriteLine("2：検索");
            Console.WriteLine("9：終了");
            Console.Write(">");
            String menuSelect = Console.ReadLine();
            return menuSelect;
        }
    }
}



/*          var employeeDict = new Dictionary<int, Employee> {
 { 100, new Employee(100, "清水遼久") },
 { 112, new Employee(112, "芹沢洋和") },
 { 125, new Employee(125, "岩瀬奈央子") },
};

          employeeDict.Add(126, new Employee(126, "庄野彩花"));

          /*var name = employeeDict.Where(e => e.Value.Name.Contains("和"));

          Console.WriteLine(name);
          foreach (var item in employeeDict.Keys) {
              Console.WriteLine($"{item}");
          }

      }
  }
}

var result = employeeDict.Remove(126);
// 以下、確認のためのコード
var emp0 = employeeDict[100];
Console.WriteLine($"{emp0.Id} {emp0.Name}");
var emp1 = employeeDict[112];
Console.WriteLine($"{emp1.Id} {emp1.Name}");
var emp2 = employeeDict[125];
Console.WriteLine($"{emp2.Id} {emp2.Name}");
var emp3 = employeeDict[125];
Console.WriteLine($"{emp2.Id} {emp2.Name}");
{ "sunflower", 400 },
{ "pansy", 300 },
{ "tulip", 350 },
{ "rose", 500 },
{ "dahlia", 450 },
};
Console.WriteLine(flowerDict["sunflower"]);
Console.WriteLine(flowerDict["dahlia"]);*/