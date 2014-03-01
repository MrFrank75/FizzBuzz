using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IBuzzCounter
    {
        string GetMessageForFizz();
        string GetResult();
        IBuzzCounter GetNewItem();
    }
}
