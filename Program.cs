using GenericList.Utilities;
using GenericList.Models;
using GenericList.Strategies;
using GenericList.Display;

// Example Client Code
class Program
{
    static void Main()
    {
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Original Linked List:");
        var display = new LinkedListDisplay<int>(list);
        display.Display();

        ActionPermissionChecker<int> checker = new ActionPermissionChecker<int>(CheckConditions);

        if (checker.IsActionAllowed(1))
        {
            Console.WriteLine("Processing each element in the linked list...");

            var strategySelector = new DynamicStrategySelector();
            var strategy = strategySelector.SelectStrategy(list);

            list.ProcessEachElement(strategy);
        }

        Console.WriteLine("After Processing:");
        display.Display();
    }

    // Simple condition for the ActionPermissionChecker
    static bool CheckConditions(int param)
    {
        Console.WriteLine($"Checking conditions for parameter: {param}");
        return param > 0;
    }
}
