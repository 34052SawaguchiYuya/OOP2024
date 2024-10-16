using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using TextNumberSizeChange.Framework;

namespace TextNumberSizeChange {
    class ToHankakuProcessor : ITextFileService {

        private int _count;
        //char[] _char = { '1', '2', '3', '4', '5', '6', '7', '8', '9','0'};

        public void Initialize(string fname) {
            _count = 0;
        }

        protected void Execute(string line) {
            _count++;
        }

        protected void Terminate() {
            Console.WriteLine("{0} 行", _count);
        }
    }
}
