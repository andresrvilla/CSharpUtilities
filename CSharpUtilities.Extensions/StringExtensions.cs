using System;

namespace CSharpUtilities.Extensions
{
    public static class StringExtensions
    {
        public static int ToInt32(this string me)
        {
            try
            {
                return Int32.Parse(me);
            }
            catch
            {
                return 0;
            }
        }
    }
}
