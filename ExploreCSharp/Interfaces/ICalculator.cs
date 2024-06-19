
namespace ExploreCSharp.Interfaces
{
    public interface ICalculator
    {
        int Number1 { get; set; }
        int Number2 { get; set; }
        void AddTwoNumbers(int number1, int number2);
    }
}
