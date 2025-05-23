using System.Globalization;

namespace Extention
{
    public static class Extentions
    {
        public static void PutInConsole(this string strings)
        {
            Console.WriteLine(strings);
        }
        public static string GetPersianDate(this DateTime GregorianDate)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(GregorianDate)} / {pc.GetMonth(GregorianDate)} / {pc.GetDayOfMonth(GregorianDate)} / {pc.GetHour(GregorianDate)}:{pc.GetMinute(GregorianDate)}:{pc.GetSecond(GregorianDate)} " ;
        }
    }
}
