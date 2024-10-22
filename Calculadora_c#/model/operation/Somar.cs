using InterfaceOperation;
namespace adicao
{
    public class Somar : IOperation
    {
        public int calc(int value1, int value2)
        {
            return value1 + value2;
        }
}
}