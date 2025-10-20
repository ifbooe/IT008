using System;
using System.Collections.Generic;
using System.Numerics;

namespace Bai04
{
    class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Mau so khong duoc bang 0.");

            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int num = a.Numerator * b.Numerator;
            int den = a.Denominator * b.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
                throw new DivideByZeroException("Khong the chia cho phan so co tu so bang 0.");
            int num = a.Numerator * b.Denominator;
            int den = a.Denominator * b.Numerator;
            return new Fraction(num, den);
        }

        public double ToDouble() => (double)Numerator / Denominator;

        public override string ToString() => $"{Numerator}/{Denominator}";
    }

    class Program
    {
        private static Fraction InputFraction(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong. Vui long nhap lai.");
                    continue;
                }

                string[] parts = input.Split('/');
                if (parts.Length != 2)
                {
                    Console.WriteLine("Nhap sai dinh dang. Vui long nhap theo dang a/b");
                    continue;
                }

                if (!BigInteger.TryParse(parts[0], out BigInteger num) ||
                    !BigInteger.TryParse(parts[1], out BigInteger den))
                {
                    Console.WriteLine("Chi duoc nhap so nguyen hop le.");
                    continue;
                }

                if (num < -1000000 || num > 1000000 || den < -1000000 || den > 1000000)
                {
                    Console.WriteLine("Gia tri phai nam trong khoang [-1000000, 1000000].");
                    continue;
                }

                if (den == 0)
                {
                    Console.WriteLine("Mau so khong duoc bang 0. Vui long nhap lai.");
                    continue;
                }

                return new Fraction((int)num, (int)den);
            }
        }

        private static List<Fraction> InputFractionList()
        {
            List<Fraction> fractions = new List<Fraction>();
            int n;

            while (true)
            {
                Console.Write("Nhap so luong phan so: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out n) || n <= 0 || n > 1000)
                {
                    Console.WriteLine("Vui long nhap so nguyen duong hop le (1 - 1000).");
                    continue;
                }
                break;
            }

            Console.WriteLine($"Nhap {n} phan so (dang a/b, cach nhau boi dau cach):");
            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("Du lieu khong duoc de trong. Vui long nhap lai.");
                    continue;
                }

                string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != n)
                {
                    Console.WriteLine($"Can nhap dung {n} phan so.");
                    continue;
                }

                bool valid = true;
                fractions.Clear();

                foreach (var p in parts)
                {
                    string[] fracParts = p.Split('/');
                    if (fracParts.Length != 2 ||
                        !BigInteger.TryParse(fracParts[0], out BigInteger num) ||
                        !BigInteger.TryParse(fracParts[1], out BigInteger den) ||
                        den == 0 ||
                        num < -1000000 || num > 1000000 ||
                        den < -1000000 || den > 1000000)
                    {
                        Console.WriteLine($"Phan so '{p}' khong hop le. Vui long nhap lai toan bo day.");
                        valid = false;
                        break;
                    }

                    fractions.Add(new Fraction((int)num, (int)den));
                }

                if (valid) break;
            }

            return fractions;
        }

        private static void PrintList(List<Fraction> list)
        {
            foreach (var f in list)
                Console.Write(f + " ");
            Console.WriteLine();
        }

        private static Fraction FindMax(List<Fraction> list)
        {
            Fraction max = list[0];
            foreach (var f in list)
                if (f.ToDouble() > max.ToDouble())
                    max = f;
            return max;
        }

        static void Main()
        {
            Console.WriteLine("Yeu cau 1: Phep toan tren hai phan so");
            Console.WriteLine("Nhap hai phan so (dang a/b c/d):");
            Fraction f1, f2;

            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("Khong duoc de trong. Vui long nhap lai.");
                    continue;
                }

                string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    Console.WriteLine("Nhap sai dinh dang. Vui long nhap theo dang a/b c/d");
                    continue;
                }

                try
                {
                    f1 = InputFromString(parts[0]);
                    f2 = InputFromString(parts[1]);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Vui long nhap lai.");
                }
            }

            Console.WriteLine();
            try
            {
                Console.WriteLine("Tong: " + (f1 + f2));
                Console.WriteLine("Hieu: " + (f1 - f2));
                Console.WriteLine("Tich: " + (f1 * f2));
                Console.WriteLine("Thuong: " + (f1 / f2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Loi khi thuc hien phep chia: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khac: " + ex.Message);
            }

            Console.WriteLine("\nYeu cau 2: Danh sach phan so");
            var list = InputFractionList();

            Console.WriteLine("\nDanh sach phan so ban dau:");
            PrintList(list);

            Fraction max = FindMax(list);
            Console.WriteLine($"Phan so lon nhat: {max}");

            list.Sort((a, b) => a.ToDouble().CompareTo(b.ToDouble()));
            Console.WriteLine("Danh sach sau khi sap xep tang dan:");
            PrintList(list);

            Console.ReadLine();
        }

        private static Fraction InputFromString(string input)
        {
            string[] parts = input.Split('/');
            if (parts.Length != 2)
                throw new Exception("Dinh dang phan so khong hop le.");
            if (!BigInteger.TryParse(parts[0], out BigInteger num) ||
                !BigInteger.TryParse(parts[1], out BigInteger den))
                throw new Exception("Chi duoc nhap so nguyen hop le.");
            if (den == 0)
                throw new Exception("Mau so khong duoc bang 0.");
            if (num < -1000000 || num > 1000000 || den < -1000000 || den > 1000000)
                throw new Exception("Gia tri nam ngoai khoang [-1000000, 1000000].");

            return new Fraction((int)num, (int)den);
        }
    }
}
