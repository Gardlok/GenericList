

namespace GenericList.Strategies
{
    // Strategy that increments the input value
    public class IncrementStrategy : IProcessingStrategy<int>
    {
        public int Process(int input)
        {
            return input + 1;
        }
    }
}