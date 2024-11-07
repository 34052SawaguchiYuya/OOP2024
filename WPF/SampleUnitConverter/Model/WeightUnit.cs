using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    internal class WeightUnit {
        public class ImperialUnit : DistanceUnit {
            private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name = "t",Coefficients = 1,},
            new ImperialUnit{Name = "kg",Coefficients = 1 * 1000,},
        };
            public static ICollection<ImperialUnit> Units { get { return units; } }

            //name="unit"
            //name="value"

            public double FromMetricUnit(ImperialUnit unit, double value) {
                return (value * unit.Coefficients) / 25.4 / this.Coefficients;
            }
        }
    }
}

