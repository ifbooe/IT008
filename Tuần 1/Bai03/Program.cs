//3.Viết chương trình nhập ngày tháng năm, cho biết ngày tháng năm đó có hợp lệ 
//không?
using System;
using System.Numerics;

namespace Bai03
{
    class Program
    {
        private static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        private static bool IsValidDate(int day, int month, int year)
        {
            if (year <= 0) return false;
            if (month < 1 || month > 12) return false;

            int daysInMonth;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = IsLeapYear(year) ? 29 : 28;
                    break;
                default:
                    return false;
            }

            return (day >= 1 && day <= daysInMonth);
        }

        private static (int day, int month, int year) CheckDateInput(string message)
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

        static void Main(string[] args)
        {
            while (true)
            {
                var (day, month, year) = CheckDateInput("Nhap ngay thang nam: ");

                if (IsValidDate(day, month, year))
                {
                    Console.WriteLine($"{day}/{month}/{year} la ngay hop le");
                    break;
                }
                else
                {
                    Console.WriteLine($"{day}/{month}/{year} khong phai ngay hop le, vui long nhap lai\n");
                }
            }

            Console.ReadLine();
        }
    }
}
