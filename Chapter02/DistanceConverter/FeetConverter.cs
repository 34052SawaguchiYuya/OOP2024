using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    internal class FeetConverter {
        public static readonly double ratio = 0.3048;

            //フィールドからメートルを求める
            public double FromMeter(double meter) {
                return meter / ratio;
            }
            //フィールドからメートルを求める
            public double ToMeter(double feet) {
                return feet * ratio;
        }
    }
}
