using InterfaceOperation;
namespace divisao
{
    public class Dividir : IOperation
    {

        public int calc(int value1, int value2)
        {
            if (value2 == 0) throw new ArithmeticException("xxxx");
            return value1 / value2;
        }
    }
}