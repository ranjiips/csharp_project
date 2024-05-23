using System;

namespace ConsoleApp1
{
    static class staticDemo
    {
        static int x = 10, y;
        static public int calcute()
        {
            y = x * x;
            return y;
        }        
    }

}
