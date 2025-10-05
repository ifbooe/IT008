//4. Viết chương trình nhập vào tháng và năm. In ra số ngày của tháng đó.
using System;
using System.Numerics;

namespace Bai04
{
    class Program
    {
        private static bool IsLeapYear(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }

        private static int MonthDay(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    return -1;
            }
        }

        private static (int month, int year) CheckInput(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong, vui long nhap lai.\n");
                    continue;
                }

                string[] parts = input.Split(new[] { '/', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                {
                    Console.WriteLine("Dinh dang khong hop le, vui long nhap theo dinh dang month/year.\n");
                    continue;
                }

                if (!BigInteger.TryParse(parts[0], out BigInteger bigMonth) ||
                    !BigInteger.TryParse(parts[1], out BigInteger bigYear))
                {
                    Console.WriteLine("Gia tri khong hop le, vui long nhap so nguyen.\n");
                    continue;
                }

                if (bigMonth < 1 || bigMonth > 12 || bigYear < 1 || bigYear > 9999)
                {
                    Console.WriteLine("Thang phai nam trong khoang [1-12], nam phai nam trong khoang [1-9999]. Vui long nhap lai.\n");
                    continue;
                }

                return ((int)bigMonth, (int)bigYear);
            }
        }

        static void Main(string[] args)
        {
            var (month, year) = CheckInput("Nhap thang/nam: ");

            int days = MonthDay(month, year);

            Console.WriteLine($"Thang {month}/{year} co {days} ngay.");
            Console.ReadLine();
        }
    }
}
