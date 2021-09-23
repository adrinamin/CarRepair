using System;

namespace CarRepair.SharedKernel
{
    public static class StringManipulator
    {
        public static string Manipulate(string input)
        {
            var arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}