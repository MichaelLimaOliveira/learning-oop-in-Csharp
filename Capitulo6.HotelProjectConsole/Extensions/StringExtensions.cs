using System.Text.RegularExpressions;

namespace Capitulo6.HotelProjectConsole.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhiteSpaces(this string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }
    }
}
