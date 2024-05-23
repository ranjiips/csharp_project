namespace CsharpConsole
{
    class Calculator
    {
        public int AddNumbers(params int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
                sum += num;
            
            return sum;
        }

        public void DivedeTwoNumbers(ref int dividend, ref int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
    }
}
