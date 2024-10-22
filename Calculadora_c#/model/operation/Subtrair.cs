using InterfaceOperation;
namespace subtracao
{
    public class Subtrair : IOperation
    {
        public int calc(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}