using InterfaceOperation;
namespace multiplicacao
{
    public class Multiplicar : IOperation
    {
        public int calc(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}