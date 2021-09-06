using System;

namespace CarRepair.SharedKernel
{
    public static class Guard
    {
        public static void IsNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}