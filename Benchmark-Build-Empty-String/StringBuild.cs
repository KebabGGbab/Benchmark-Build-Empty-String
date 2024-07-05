using System.Text;

namespace String_Build
{
    internal static class StringBuild
    {
        public static string StringEmpty()
        {
            return String.Empty;
        }
        public static string Quotes()
        {
            return "";
        }
        public static string StringBulder()
        {
            return new StringBuilder().ToString();
        }
        public static string NewString()
        {
            return new string("");
        }
    }
}
