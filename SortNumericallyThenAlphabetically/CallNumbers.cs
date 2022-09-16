using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumericallyThenAlphabetically
{
    public class CallNumbers
    {
        private double callNumber;
        private string callLetter;

        public CallNumbers()
        {
            // EMPTY CONSTRUCTOR, DO NOT REMOVE
        }

        // Constructor
        public CallNumbers(double callNumbers, string callLetters)
        {
            this.callNumber = callNumbers;
            this.callLetter = callLetters;
        }

        // Getter and setter methods
        public double CallNumber { get => callNumber; set => callNumber = value; }
        public string CallLetter { get => callLetter; set => callLetter = value; }
    }
}
