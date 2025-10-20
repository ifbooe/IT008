using System;

namespace Bai01
{
    class Program
    {
        static void Main()
        {
            int month, year;

            while (true)
            {
                Console.Write("Nhap thang va nam theo dinh dang mm/yyyy: ");
                string input = Console.ReadLine()?.Trim() ?? "";

                string[] parts = input.Split('/');
                if (parts.Length == 2 && int.TryParse(parts[0], out month) && int.TryParse(parts[1], out year) && month >= 1 && month <= 12 && year >= 1 && year <= 9999)
                {
                    break;
                }

                Console.WriteLine("Khong hop le, vui long nhap lai (1 <= month <= 12, 1 <= year <= 9999)");
            }

            PrintCalendar(month, year);
            Console.ReadLine();
        }

        static void PrintCalendar(int month, int year)
        {
            Console.WriteLine($"\nMonth: {month:D2}/{year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

            int days = DateTime.DaysInMonth(year, month);
            int startDay = (int)new DateTime(year, month, 1).DayOfWeek;

            for (int i = 0; i < startDay; i++)
                Console.Write("    ");

            for (int day = 1; day <= days; day++)
            {
                Console.Write($"{day,3} ");
                if ((startDay + day) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
