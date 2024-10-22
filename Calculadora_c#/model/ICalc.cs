using InterfaceOperation;

namespace InterfaceCalculadora
{
    public interface ICalc
    {
        public int calculation(IOperation operation, int value1, int value2);
    }
}