using InterfaceCalculadora;
using InterfaceOperation;

namespace calculadora
{
    public class Calc : ICalc
    {

    public int calculation(IOperation operation, int value1, int value2)
    {

        return operation.calc(value1, value2);
    }

}
}