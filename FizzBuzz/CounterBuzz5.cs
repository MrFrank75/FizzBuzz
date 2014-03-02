using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class CounterBuzz5 : IBuzzCounter
    {
        private ICounterItem counterStandard;

        public CounterBuzz5(ICounterItem counterStandard)
        {
            // TODO: Complete member initialization
            this.counterStandard = counterStandard;
        }
        public string GetResult()
        {
            counterStandard.GetResult(); 
            return "Buzz";
        }

        public IBuzzCounter GetNewItem()
        {
            return new CounterBuzz1(counterStandard.GetNewItem());
        }

        public string GetMessageForFizz()
        {
            counterStandard.GetResult(); 
            return "Buzz";
        }
    }
}
