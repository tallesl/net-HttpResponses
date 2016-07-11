namespace HttpResponsesLibrary
{
    using System.Globalization;
    using System.Linq;
    using System.Text;

    internal static class DiacriticsRemover
    {
        internal static string WithoutDiacritics(this string s)
        {
            return new string(
                s.Normalize(NormalizationForm.FormD)
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray()
            );
        }
    }
}
