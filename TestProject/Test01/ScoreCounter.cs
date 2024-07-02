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
                    Name = item[0],Subject = item[1],Score = int.Parse(item[2]),
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