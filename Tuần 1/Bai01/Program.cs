using System;
using System.Numerics;
//1.Viết chương trình cho phép tạo mảng một chiều gồm n số nguyên ngẫu nhiên. 
//Cài đặt hàm thực hiện các chức năng sau: 
//a.Tính tổng các số lẻ trong mảng 
//b. Đếm số nguyên tố trong mảng 
//c. Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1)

namespace Bai01
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

                //Kiem tra de trong
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong. Vui long nhap lai");
                    continue;
                }

                //Kiem tra so nguyen
                if (!BigInteger.TryParse(input, out bigN))
                {
                    Console.WriteLine("Vui long nhap so nguyen n");
                    continue;
                }

                //Kiem tra so am
                if (bigN < 0)
                {
                    Console.WriteLine("Khong the tao mang n phan tu voi n am, vui long nhap lai");
                    continue;
                }

                //Kiem tra tran so
                if (bigN > MAX_SIZE)
                {
                    Console.WriteLine("Vui long nhap so nguyen n nho hon " + MAX_SIZE);
                    continue;
                }

                return (int)bigN;
            }
        }




        //Ham input mang n
        private static int[] Input(int n)
        {
            int[] arr = new int[n];
            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(int.MinValue, int.MaxValue);
            }
            return arr;
        }

        //check so le
        private static bool IsOdd(int x)
        {
            return x % 2 != 0;
        }

        //check so nguyen to
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

        //check so chinh phuong
        private static bool IsPerfectSquare(int x)
        {
            if (x < 0) return false;
            int root = (int)Math.Sqrt(x);
            return root * root == x;
        }

        static void Main(string[] args)
        {
            int n = CheckInput("Nhap so nguyen n:");
            int[] arr = Input(n);
            bool hasOdd = false;
            BigInteger oddsum = 0;    //xu ly tran so
            int cnt = 0;
            int perfectsquarenum = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsOdd(arr[i]))
                { 
                    oddsum += arr[i];
                    hasOdd = true;
                }

                if (IsPrime(arr[i]))
                {
                    cnt++;
                }

                if (IsPerfectSquare(arr[i]))
                {
                    perfectsquarenum = Math.Min(perfectsquarenum, arr[i]);
                }
            }

            if (perfectsquarenum == int.MaxValue)
                perfectsquarenum = -1;
            Console.WriteLine("");

            //a.Tính tổng các số lẻ trong mảng 
            if (!hasOdd)
            {
                Console.WriteLine("Khong co so le nao trong mang");
            }
            else
            {
                Console.Write("Tong cac so le trong mang: ");
                Console.WriteLine(oddsum);
            }

            //b. Đếm số nguyên tố trong mảng 
            if (cnt == 0)
            {
                Console.WriteLine("Khong co so nguyen to nao trong mang");
            }

            else
            {
                Console.Write("So luong so nguyen to trong mang: ");
                Console.WriteLine(cnt);
            }

            // c. Tìm số chính phương nhỏ nhất (nếu không có hàm trả về -1)
            if (perfectsquarenum == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine("So chinh phuong nho nhat trong mang: " + perfectsquarenum);
            }
            Console.ReadLine();
        }
    }
}
