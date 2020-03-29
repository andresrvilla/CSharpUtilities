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

        public static Guid ToGuid(this string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("id");
            }
            Guid guid = new Guid();

            if (!Guid.TryParse(id, out guid))
            {
                throw new InvalidCastException();
            }

            return guid;
        }
    }
}
