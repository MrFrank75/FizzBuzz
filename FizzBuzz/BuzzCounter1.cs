using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    class BuzzCounter1 :  IBuzzCounter
    {
        NumberCounter _numberCounter;

        public BuzzCounter1(NumberCounter numberCounter)
        {
            _numberCounter = numberCounter;
        }

        public string GetResult()
        {
            return _numberCounter.GetResult();
        }

        public IBuzzCounter Move()
        {
            return new BuzzCounter2(_numberCounter);
        }


        public string GetMessageForFizz()
        {
            return string.Empty;
        }
    }

    class BuzzCounter2 : IBuzzCounter
    {
         NumberCounter _numberCounter;

        public BuzzCounter2(NumberCounter numberCounter)
        {
            _numberCounter = numberCounter;
        }

        public string GetResult()
        {
            return _numberCounter.GetResult();
        }

        public IBuzzCounter Move()
        {
            return new BuzzCounter3(_numberCounter);
        }


        public string GetMessageForFizz()
        {
            return string.Empty;
        }
    }

    class BuzzCounter3 : IBuzzCounter
    {

         NumberCounter _numberCounter;

        public BuzzCounter3(NumberCounter numberCounter)
        {
            _numberCounter = numberCounter;
        }

        public string GetResult()
        {
            return _numberCounter.GetResult();
        }

        public IBuzzCounter Move()
        {
            return new BuzzCounter4(_numberCounter);
        }


        public string GetMessageForFizz()
        {
            return string.Empty;
        }
    }

    class BuzzCounter4 : IBuzzCounter
    {

         NumberCounter _numberCounter;

        public BuzzCounter4(NumberCounter numberCounter)
        {
            _numberCounter = numberCounter;
        }

        public string GetResult()
        {
            return _numberCounter.GetResult();
        }

        public IBuzzCounter Move()
        {
            return new BuzzCounter5(_numberCounter);
        }


        public string GetMessageForFizz()
        {
            return string.Empty;
        }
    }

    class BuzzCounter5 : IBuzzCounter
    {
          NumberCounter _numberCounter;

        public BuzzCounter5(NumberCounter numberCounter)
        {
            _numberCounter = numberCounter;
        }

        public string GetResult()
        {
            _numberCounter.GetResult();
            return "Buzz";
        }

        public IBuzzCounter Move()
        {
            return new BuzzCounter1(_numberCounter);
        }

        public string GetMessageForFizz()
        {
            _numberCounter.GetResult();
            return "Buzz";
        }
    }
}
