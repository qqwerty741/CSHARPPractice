using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class Sero_buro_malinovi
    {
        private string _input;
        public string Input => _input;

        protected Sero_buro_malinovi(string input)
        {
            _input = input;
        }
        public abstract void Review();
        public virtual void ChangeText(string input)
        {
            _input = input;
            Review();
        }
    }
}
