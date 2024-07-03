using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public class SampleClass
    {
        private int number1;
        private int number2;

        public int Number1
        {
            get { return number1; }
            set { number1 = value;}
        }

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public int Number3 { get; set; }
        public SampleClass(int Number1, int Number2)
        {
            this.Number1 = Number1;
            this.Number2 = Number2;
            this.Number3 = this.Number1;
        }

        public void AddTwoNumbers()
        {
            Console.WriteLine(this.Number1 + this.Number2);
        }

        public void MulitpleTwoNumbers()
        {
            Console.WriteLine(this.Number1 * this.Number2);
        }

    }
}
