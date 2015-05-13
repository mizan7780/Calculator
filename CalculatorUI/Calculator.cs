using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUI
{
    class Calculator
    {
        

        public int Add(int fNumber, int sNumber)
        {

            return fNumber + sNumber;
        }

        public int Subtract(int fNumber, int sNumber)
        {

            return fNumber - sNumber;
        }

        public int Multiply(int fNumber, int sNumber)
        {

            return fNumber * sNumber;
        }

        public int Divide(int fNumber, int sNumber)
        {

            return fNumber / sNumber;
        }

        internal string Add(int p)
        {
            throw new NotImplementedException();
        }
    }
}
