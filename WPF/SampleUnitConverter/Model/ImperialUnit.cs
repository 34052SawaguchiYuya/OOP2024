using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    //メートル単位を表すクラス
    public class ImperialUnit : DistanceUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name = "in",Coefficients = 1,},
            new ImperialUnit{Name = "ft",Coefficients = 12,},
            new ImperialUnit{Name = "yd",Coefficients = 12 * 3,},
            new ImperialUnit{Name = "ml",Coefficients = 12 * 3 * 1760,},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        //name="unit"
        //name="value"

        public double FromMetricUnit(ImperialUnit unit, double value) {
            return (value * unit.Coefficients) / 25.4 / this.Coefficients;
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
