//5.Viết chương trình nhập vào ngày tháng năm, cho biết thứ trong tuần.
using System;
using System.Numerics;

namespace Bai05
{
    class Program
    {
        private static (int day, int month, int year) CheckInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong. Vui long nhap lai.\n");
                    continue;
                }


                string[] parts = input.Split(new[] { '/', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 3)
                {
                    Console.WriteLine("Vui long nhap dung dinh dang: ngay thang nam (day/month/year)\n");
                    continue;
                }

                if (!BigInteger.TryParse(parts[0], out BigInteger bigDay) ||
                    !BigInteger.TryParse(parts[1], out BigInteger bigMonth) ||
                    !BigInteger.TryParse(parts[2], out BigInteger bigYear))
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap so nguyen.\n");
                    continue;
                }

                if (bigDay < 1 || bigDay > 31 || bigMonth < 1 || bigMonth > 12 || bigYear < 1 || bigYear > 9999)
                {
                    Console.WriteLine("Gia tri ngay thang nam khong hop le (ngay [1-31], thang [1-12], nam [1-9999])\n");
                    continue;
                }

                return ((int)bigDay, (int)bigMonth, (int)bigYear);
            }
        }

        private static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        private static int DaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: return 31;
                case 4: case 6: case 9: case 11: return 30;
                case 2: return IsLeapYear(year) ? 29 : 28;
                default: return -1;
            }
        }

        private static string DayOfWeek(int d, int m, int y)
        {
            if (m < 3)
            {
                m += 12;
                y -= 1;
            }

            int h = (d + (13 * (m + 1)) / 5 + y + y / 4 - y / 100 + y / 400) % 7;

            switch (h)
            {
                case 0: return "Thu bay";
                case 1: return "Chu nhat";
                case 2: return "Thu hai";
                case 3: return "Thu ba";
                case 4: return "Thu tu";
                case 5: return "Thu nam";
                case 6: return "Thu sau";
                default: return "";
            }
        }

        static void Main(string[] args)
        {
            var (day, month, year) = CheckInput("Nhap ngay/thang/nam: ");

            string thu = DayOfWeek(day, month, year);

            Console.WriteLine($"{day}/{month}/{year} la {thu}.");
            Console.ReadLine();
        }
    }
}
