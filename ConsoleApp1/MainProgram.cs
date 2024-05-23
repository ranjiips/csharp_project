using System;

namespace ConsoleApp1
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Pre_Post_Increment();
            Console.WriteLine("Y value from static method: " + staticDemo.calcute());
        }

        public static void Pre_Post_Increment()
        {
            Console.WriteLine("Pre and Post Increment Operators");
            int i, j;
            i = 2;
            j = ++i;
            Console.WriteLine("j=" + j);
            Console.WriteLine("i=" + i);
            j = i++;
            Console.WriteLine("j=" + j);
            j = i--;
            Console.WriteLine("i=" + i);
            --j;
            Console.WriteLine("j=" + j);
            j -= i;
            Console.WriteLine("j=" + j);
            Console.WriteLine("i=" + i);
            j = ++i;
            Console.WriteLine("j=" + --j);
            Console.WriteLine("i=" + i--);
            Console.WriteLine("i=" + i);
        }
    }
}
