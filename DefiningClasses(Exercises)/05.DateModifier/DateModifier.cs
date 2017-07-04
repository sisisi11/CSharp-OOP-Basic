using System;
using System.Globalization;

public class DateModifier
{
    public static string DifferenceBetweenTwoDates(string date1, string date2)
    {
        DateTime firstDate = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);

        if (firstDate >= secondDate)
        {
            var s = (firstDate - secondDate).Days;
            return s.ToString();
        }
        else
        {
            var s = (secondDate - firstDate).Days;
            return s.ToString();
        }
    }
}