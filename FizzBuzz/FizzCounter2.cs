using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzCounter2 :  IFizzCounter
    {
         private IBuzzCounter buzzCounter;

        public FizzCounter2(IBuzzCounter buzzCounter)
        {
            // TODO: Complete member initialization
            this.buzzCounter = buzzCounter;
        }

        public  string GetResult()
        {
            return buzzCounter.GetResult();
        }

         public  IFizzCounter Move()
        {
            return new FizzCounter3(buzzCounter.Move());
        }
    }
}
