namespace Extention
{
    public class Program
    {
        public static void Main(string[] args)
        {
            "Hello, world!".PutInConsole();
            DateTime today = DateTime.Today;
            Console.WriteLine(today.GetPersianDate());
            today.GetPersianDate();
        }
    }
}
