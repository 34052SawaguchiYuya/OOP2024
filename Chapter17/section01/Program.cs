using Section01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section01 {
    internal class Program {
        static void Main(string[] args) {
            var greeting = new List<GreetingBase>() {
                new GreetingMorning(),
                new GreetingAfternoon(),
                new GreetingEvening(),
            };

            foreach(var obj in greetings) { 
                string msg = obj.GetMessage();
                Console.WriteLine(msg);
            }
        }
    }
}
