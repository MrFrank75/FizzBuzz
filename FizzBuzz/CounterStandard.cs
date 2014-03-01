using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class CounterStandard : ICounterItem
    {
        int _internalIndex = 0;

        public  string GetResult()
        {
            _internalIndex++;
            return _internalIndex.ToString();
        }

        public  ICounterItem GetNewItem()
        {
            return this;
        }
    }
}
