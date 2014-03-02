using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzCounter3 :  IFizzCounter
    {

         private IBuzzCounter buzzCounter;

        public FizzCounter3(IBuzzCounter buzzCounter)
        {
            // TODO: Complete member initialization
            this.buzzCounter = buzzCounter;
        }

        public  string GetResult()
        {
            return "Fizz" + buzzCounter.GetMessageForFizz();
        }

        public  IFizzCounter Move()
        {
            return new FizzCounter1(buzzCounter.Move());
        }
    }
}
