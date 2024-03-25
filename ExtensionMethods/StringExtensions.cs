using System;
using System.Linq;

namespace ExtensionMethods
{
    //We cannot change or inherit from sealed classes.
    //TO create Extension Method, we need to create Static class. This is convention.
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numOfWords)
        {
            if (numOfWords <= 0)
            {
                throw new ArgumentOutOfRangeException("Out Of Range");
            }
            if (numOfWords >= str.Length)
                return str;
            else
            {
                var splitStrArr = str.Split(' ');
                return string.Join(' ', splitStrArr.Take(numOfWords))+ " .....";

                
            }
        }
    }
}
