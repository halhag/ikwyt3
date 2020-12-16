using System;
using System.Linq;

namespace IKWYT.Data
{
    public class StringHelper
    {
        public static string FirstCharToUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("ARGH!");
            }
            return input.First().ToString().ToUpper() + string.Join("", input.Skip(1));
        }
    }
}
