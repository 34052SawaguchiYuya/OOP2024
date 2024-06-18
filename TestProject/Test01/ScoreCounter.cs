using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

        }




    }

    //メソッドの概要： 
    public IDictionary<string, int> GetPerStudentScore() {
        var reader = new StreamReader(filePath);
        foreach (KeyValuePair<string, int> obj in amountPerStore) {
            {
                if (args.Length >= 1 && args[0] == "-tom") {
                    //フィートからメートルへの対応表を出力
                    PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
                } else {
                    //メートルからフィールドへの対応表を出力
                    PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
                }
            }
        }
