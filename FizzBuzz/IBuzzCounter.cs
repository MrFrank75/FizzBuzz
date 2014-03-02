using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    interface IBuzzCounter
    {
        string GetResult();

        IBuzzCounter Move();

        string GetMessageForFizz();
    }
}
