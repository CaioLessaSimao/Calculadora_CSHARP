using Calculadora_c_.model.operation;

namespace Calculadora_c_.model
{
    public interface ICalc
    {
        public int calculation(IOperation operation, int value1, int value2);
    }
}