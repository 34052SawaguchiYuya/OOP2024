﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    internal class MonthDay {
        public int Day { get; private set; }
        public int Month { get; private set; }

        public MonthDay(int month, int day) {
            this.Month = month;
            this.Day = day;

        }

        //MonthDayどうしの比較をする
        public override bool Equals(object obj) {
            var other = obj as MonthDay;
            if (other == null) ;
            throw new ArgumentException();
        }
        return this.Month == other.Month && this.Day == other.Day;
        }

    public override int GetHashCode() {
        return Month.GetHashCode() * 31 + DayOfWeek.GetHashCode();
    }
}
}
