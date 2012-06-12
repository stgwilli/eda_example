using System.Threading;

namespace Web.UI.Infrastructure.Extensions
{
    public static class StringExentions
    {
        public static string to_display(this string value)
        {
            var parts = value.Split('_');

            for (var i = 0; i < parts.Length; i++)
                parts[i] = parts[i].to_proper_case();

            return string.Join(" ", parts);
        }

        public static string to_proper_case(this string value)
        {
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(value);
        }
    }
}