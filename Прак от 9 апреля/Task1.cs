using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Task1 : Sero_buro_malinovi
    {
        private int _output;
        public int Output => _output;

        public Task1(string text):base(text) => _output = 0;

        public override void Review()
        {
            _output = 1;
        }
        public override string ToString()
        {
            return _output.ToString();
        }
    }
}
