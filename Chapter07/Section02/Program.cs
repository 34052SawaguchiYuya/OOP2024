using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    internal class Program {
        static void Main(string[] args) {
            var lines = File.ReadAllLines("sample.txt");
            var we = new WordsExtractor(lines);
            foreach (var word in we.Extract()) {
                Console.WriteLine(word);
                /*var dict = new Dictionary<MonthDay, string> {
                { new MonthDay(3, 5),"珊湖の日"},
                { new MonthDay(3, 5),"箸の日"},
                { new MonthDay(3, 5),"登山の日"},
            };
                var md = new MonthDay(8, 4);
                var s = dict[md];
                Console.WriteLine(s);*/
            }
        }
    }
}
