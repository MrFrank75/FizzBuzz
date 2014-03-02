using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class NumberCounter
    {
        int _internalCounter = 0;

        public string GetResult()
        {
            _internalCounter++;
            return _internalCounter.ToString();
        }
    }
}
