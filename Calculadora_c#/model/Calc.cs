using Calculadora_c_.model.operation;

namespace Calculadora_c_.model
{
    public class Calc : ICalc
    {

    public int calculation(IOperation operation, int value1, int value2)
    {

        return operation.calc(value1, value2);
    }

}
}