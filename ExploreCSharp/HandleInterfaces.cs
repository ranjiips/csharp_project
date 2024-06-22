using ExploreCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class HandleInterfaces : ICalculator
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }
        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }
        public HandleInterfaces()
        {
        }
        public int AddTwoNumbers(int n1, int n2)
        {
            this.Number1 = n1;
            this.Number2 = n2;
            return Number1 + Number2;
        }
    }
}
