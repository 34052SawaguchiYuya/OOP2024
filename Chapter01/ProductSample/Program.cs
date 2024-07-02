using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    internal class Program {
        static void Main(string[] args) {

            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(223, "大福", 250);

            int price = karinto.Price;//税抜きの金額
            int taxIncluded = karinto.GetPriceIncludingTax();//税込みの金額

            int daifukuPrice = daifuku.Price;//税抜きの金額
            int daifukuTaxIncluded = daifuku.GetPriceIncludingTax();//税込みの金額


            Console.WriteLine(karinto.Name + "の税込金額" + taxIncluded + "円【税抜き" + price + "円】");

            Console.WriteLine(daifuku.Name + "の税込金額" + daifukuTaxIncluded + "円【税抜き" + daifukuPrice + "円】");


        }
    }
}
/*
using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        //コンストラクタ
        public ScoreCounter(string filePath) {
            _score = Score(filePath);
        }

        //メソッドの概要：スコアデータを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> Score(string filePath) {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] item = line.Split(',');
                Student score = new Student() {
                    Name = item[0],
                    Subject = item[1],
                    Score = int.Parse(item[2]),
                };
                scores.Add(score);
            }
            return scores;
        }

        public IDictionary<string, int> StudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _score) {
                if (dict.ContainsKey(sale.Subject)) {
                    dict[sale.Subject] += sale.Score;
                } else {
                    dict[sale.Subject] = sale.Score;
                }
            }
            return dict;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01 {
    class Program {
        static void Main(string[] args) {
            var score = new ScoreCounter("StudentScore.csv");
            var Total = score.StudentScore();
            foreach (var obj in Total) {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;


namespace Test02 {

    class Person {
        public string Name { get; set; }  //名前
        public int Age { get; set; }      //年齢
        public int Height { get; set; }   //身長
        public int Weight { get; set; }   //体重
    }

    class Program {
        static void Main(string[] args) {
            List<int> numbers = new List<int>() {
                    12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48
                };

            var persons = new List<Person> {
                new Person{Name = "山田隆司",Age = 38, Height=170,Weight=68},
                new Person{Name = "沖田宏一",Age = 28, Height=168,Weight=59},
                new Person{Name = "池中裕次",Age = 21, Height=184,Weight=82},
                new Person{Name = "片桐鉄也",Age = 29, Height=173,Weight=74},
                new Person{Name = "片山伸介",Age = 35, Height=176,Weight=65},
            };
            #region テスト用ドライバ
            Console.WriteLine("問題１：合計値");
            Exercise01(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題２：偶数の最大値");
            Exercise02(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題３：奇数の降順");
            Exercise03(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題４：10 以上 50 以下のみ");
            Exercise04(numbers);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題５：平均年齢");
            Exercise05(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題６：身長170cm以上の体重平均");
            Exercise06(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題７：体重70kg以下の人を体重の昇順で全て表示（名前と体重を出力）");
            Exercise07(persons);
            Console.WriteLine("\n-----");

            Console.WriteLine("問題８：名前に「山」の漢字が含まれている人全て表示（名前のみ出力）");
            Exercise08(persons);
            Console.WriteLine("\n-----");
            #endregion
        }

        //---------------------------------------
        // 以下の問題に書かれている内容を満たすようにプログラムを作成せよ。
        // 必要であればラムダ式とLINQを使用すること
        //---------------------------------------

        //問題１　合計値を表示
        //　　　　出力結果【618】
        private static void Exercise01(List<int> numbers) {
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        //問題２　偶数の最大値を表示
        //　　　　出力結果【94】
        private static void Exercise02(List<int> numbers) {
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var max = evenNumbers.Max();
            Console.WriteLine(max);
        }
        //問題３　奇数のみを降順に並べて表示（遅延実行とする）
        //　　　　出力結果【91 87 53 35 31 17】
        private static void Exercise03(List<int> numbers) {
            var sortedOddNumbers = numbers.Where(n => n % 2 != 0).OrderByDescending(n => n);
            foreach (var oddNumber in sortedOddNumbers) {
                Console.Write(oddNumber + " ");
            }
        }


        //問題４　10以上50以下の数字のみを表示（即時実行でも可とする）
        //　　　　出力結果【12 14 20 40 35 31 17 48】
        private static void Exercise04(List<int> numbers) {
            var filteredNumbers = numbers.Where(n => n >= 10 && n <= 50);
            // 結果を表示
            foreach (var n in filteredNumbers) {
                Console.Write(n + " ");
            }
        }

        //問題５　平均年齢を表示
        //　　　　出力結果【30.2才】
        private static void Exercise05(List<Person> persons) {
            var age = persons.Average(n => n.Age);
            // 結果を表示
            Console.WriteLine(string.Join(", ", age) + "才");
        }

        //問題６　身長170cm以上の体重平均を表示
        //　　　　出力結果【72.25kg】
        private static void Exercise06(List<Person> persons) {
            var light = persons.FindAll(person => person.Height >= 170).Average(person => person.Weight);
            Console.WriteLine(light + "kg");
        }

        //問題７　体重70Kg以下の人を全て表示（名前と体重）
        //　　　　出力結果【山田隆司 68kg
        //　　　　　　　　　沖田宏一 59kg
        //　　　　　　　　　片山伸介 65kg】
        private static void Exercise07(List<Person> persons) {
            var lightweightPeople = persons.FindAll(person => person.Weight <= 70);
            foreach (var person in lightweightPeople) {
                Console.WriteLine($"{person.Name} {person.Weight} kg");
            }
        }

        //問題８　名前に「山」の漢字が含まれている人全て表示
        //　　　　出力結果【山田隆司
        //　　　　　　　　　片山伸介】
        private static void Exercise08(List<Person> persons) {
            var selected = persons.Where(b => b.Name.Contains("山"));
            foreach (var names in selected)
                Console.WriteLine(names.Name);
        }
    }
}
*/