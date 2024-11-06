using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class MetricUnit : DistanceUnit {
        private static List<MetricUnit> units = new List<MetricUnit> {
            new MetricUnit{Name = "mm",Coefficients = 1,},
            new MetricUnit{Name = "cm",Coefficients = 10,},
            new MetricUnit{Name = "m",Coefficients = 10 * 100,},
            new MetricUnit{Name = "km",Coefficients = 10 * 100 * 1000,},
        };
        public static ICollection<MetricUnit> Units { get { return units; } }

        public double FromImperialUnit(ImperialUnit unit, double value) {
            return (value * unit.Coefficients) * 25.4 / this.Coefficients;
        }
    }
}
    /*public class ImperialUnit : DistanceUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name = "in",Coefficients = 1,},
            new ImperialUnit{Name = "ft",Coefficients = 1,},
            new ImperialUnit{Name = "yd",Coefficients = 1,},
            new ImperialUnit{Name = "ml",Coefficients = 1,},
        };
        public static ICollection <ImperialUnit> Units { get { return units; } }
    }
}*/
