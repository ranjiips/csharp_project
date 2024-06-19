using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{
    public class EnumerationExamples
    {
        private SelectNumbers num;
        private int numbers;
        public SelectNumbers Num
        {
            get { return this.num; }
            private set { this.num = value; }
        }

        public int Numbers
        {
            get { return numbers; }
            set { this.numbers = value; }
        }
        public enum SelectNumbers
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six
        }

        public EnumerationExamples(SelectNumbers num)
        {            
            this.Num = num;
            if (this.Num.ToString() == SelectNumbers.Zero.ToString())
                this.Numbers = 0;
            else if (this.Num.ToString() == SelectNumbers.One.ToString())
                this.Numbers = 1;
            else if (this.Num.ToString() == SelectNumbers.Two.ToString())
                this.Numbers = 2;
            else if (this.Num.ToString() == SelectNumbers.Three.ToString())
                this.Numbers = 3;
            else if (this.Num.ToString() == SelectNumbers.Four.ToString())
                this.Numbers = 4;
            else if (this.Num.ToString() == SelectNumbers.Five.ToString())
                this.Numbers = 5;
            else
                this.Numbers = 6;
        }

        public void PrintTheNumber()
        {
            try
            {
                if (this.Numbers == 0)
                    Console.WriteLine($"The given number is: Zero (0)");
                else if (this.Numbers == 1)
                    Console.WriteLine($"The given number is: One (1)");
                else if (this.Numbers == 2)
                    Console.WriteLine($"The given number is: Two (2)");
                else if (this.Numbers == 3)
                    Console.WriteLine($"The given number is: Three (3)");
                else if (this.Numbers == 4)
                    Console.WriteLine($"The given number is: Four (4)");
                else if (this.Numbers == 5)
                    Console.WriteLine($"The given number is: Five (5)");
                else
                    throw new Exception($"Initialized number '{this.Numbers}' is not valid, kindly give the numbers between 0 to 5");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
