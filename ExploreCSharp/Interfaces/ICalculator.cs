
namespace ExploreCSharp.Interfaces
{
    public interface ICalculator
    {
        abstract int Number1 { get; set; }
        abstract int Number2 { get; set; }
        abstract int AddTwoNumbers(int number1, int number2);
    }
}
