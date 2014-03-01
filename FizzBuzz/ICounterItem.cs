using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public interface ICounterItem
    {
        string GetResult();
        ICounterItem GetNewItem();
    }
}
