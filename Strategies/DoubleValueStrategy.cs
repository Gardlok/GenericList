


namespace GenericList.Strategies
{
     // Strategy that doubles the input value
    public class DoubleValueStrategy : IProcessingStrategy<int>
    {
        public int Process(int input)
        {
            return input * 2;
        }
    }
}