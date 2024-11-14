Susing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter.Model {
    internal class GramUnit {
        private static List<ImperialUnit> units = new List<ImperialUnit> {
            new ImperialUnit{Name = "g",Coefficients = 12 * 3,},
            new ImperialUnit{Name = "kg",Coefficients = 12 * 3 * 1760,},
        };
        public static ICollection<ImperialUnit> Units { get { return units; } }

        //name="unit"
        //name="value"

        public double FromMetricUnit(ImperialUnit unit, double value) {
            return (value * unit.Coefficients) / 25.4;// this.Coefficients;
        }
    }
}