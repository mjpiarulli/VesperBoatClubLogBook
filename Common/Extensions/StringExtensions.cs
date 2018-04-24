namespace Common.Extensions
{
    public static class StringExtensions
    {
        public static string SafeSubstring(this string s, int length)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            if (s.Length > length)
                return s.Substring(0, length);

            return s;
        }
    }
}
