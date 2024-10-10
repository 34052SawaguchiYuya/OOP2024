using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace LineCounter {
    class LineCounterProcessor : TextProcessor{

        private int _count;

        protected override void Initialize(string fname) {
            _count = 0;
        }

        protected override void Execute(string line) {
            _count++; 
        }

        protected virtual void Terminate(string line) {
            Console.WriteLine("{0}行",_count);
        }
    }
}
