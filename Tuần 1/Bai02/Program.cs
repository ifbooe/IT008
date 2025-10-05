//2.Viết chương trình nhập số nguyên dương n, tính tổng các số nguyên tố < n và 
//xuất kết quả ra màn hình.

using System;
using System.Numerics;

namespace Bai02
{
    class Program
    {
        private static int CheckInput(string s)
        {
            BigInteger bigN;
            int MAX_SIZE = 10_000_000;

            while (true)
            {
                Console.WriteLine(s);
                string input = Console.ReadLine();

                //Kiem tra so nguyen
                if (!BigInteger.TryParse(input, out bigN))
                {
                    Console.WriteLine("Vui long nhap so nguyen duong n");
                    continue;
                }

                //Kiem tra so am
                if (bigN < 0)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong n");
                    continue;
                }

                //Kiem tra tran so
                if (bigN > MAX_SIZE)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong n nho hon " + MAX_SIZE);
                    continue;
                }

                return (int)bigN;
            }
        }

        //Chek so nguyen to
        private static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;

            int limit = (int)Math.Sqrt(x);
            for (int i = 3; i <= limit; i += 2)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = CheckInput("Nhap so nguyen duong n: ");

            //tổng các số nguyên tố < n và xuất kết quả ra màn hình.
            BigInteger sumPrime = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                {
                    sumPrime += i;
                }
            }

            Console.WriteLine("Tong cac so nguyen to < {0} la: {1}", n, sumPrime);
        }
    }
}
