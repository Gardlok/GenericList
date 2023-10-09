using GenericList.Strategies;


namespace GenericList.Models 
{
    public class DynamicStrategySelector
    {
        // Selects a processing strategy based on the list's state
        public IProcessingStrategy<int> SelectStrategy(MyLinkedList<int> list)
        {
            int count = list.Count();
            if (count > 2)
            {
                return new DoubleValueStrategy();
            }
            else
            {
                return new IncrementStrategy();
            }
        }
    }
}