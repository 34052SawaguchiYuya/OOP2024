using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintInchToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                //メートルからフィールドへの対応表を出力
                PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
            }
        }

        private static void PrintInchToMeterList(int start, int stop) {
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000}m", inch, meter);
            }
        }
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = start; meter <= stop; meter++) {
                double feet = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} inch = {1:0.0000} ft", meter, feet);
            }
        }
    }
}

