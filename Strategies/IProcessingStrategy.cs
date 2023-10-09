

namespace GenericList.Strategies
{
    // public interface IProcessingStrategy<T> where T : IEquatable<T>
    // {
    //     void Process(T data);
    // }


    // Strategy interface for processing input
    public interface IProcessingStrategy<T>
    {
        T Process(T input);
    }
}