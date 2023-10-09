using System;


namespace GenericList.Utilities
{
    public class ActionPermissionChecker<T>
    {
        // Delegate to check if an action is allowed
        public delegate bool ActionAllowedDelegate(T param);
        private readonly ActionAllowedDelegate _actionAllowed;

        // Constructor initializes the delegate
        public ActionPermissionChecker(ActionAllowedDelegate actionAllowed)
        {
            _actionAllowed = actionAllowed;
        }

        // Checks if the action is allowed and logs the result
        public bool IsActionAllowed(T param)
        {
            if (_actionAllowed(param))
            {
                Console.WriteLine("Action allowed!");
                return true;
            }
            else
            {
                Console.WriteLine("Action not allowed!");
                return false;
            }
        }
    }
}
