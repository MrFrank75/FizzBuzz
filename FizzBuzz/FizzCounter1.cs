using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class FizzCounter1 :  IFizzCounter
    {
        private IBuzzCounter buzzCounter1;

        public FizzCounter1(IBuzzCounter buzzCounter)
        {
            // TODO: Complete member initialization
            this.buzzCounter1 = buzzCounter;
        }

        public  string GetResult()
        {
            return buzzCounter1.GetResult();
        }

        public  IFizzCounter Move()
        {
            return new FizzCounter2(buzzCounter1.Move());
        }
    }
}
