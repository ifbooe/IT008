using System;
using System.Numerics;

namespace Bai03
{
    class Program
    {
        private static int CheckInput(string message, int min, int max)
        {
            BigInteger value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong. Vui long nhap lai.");
                    continue;
                }

                if (!BigInteger.TryParse(input, out value))
                {
                    Console.WriteLine("Vui long nhap so nguyen hop le.");
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.WriteLine($"Gia tri phai nam trong khoang [{min}, {max}].");
                    continue;
                }

                return (int)value;
            }
        }

        private static (int rows, int cols) InputMatrixSize()
        {
            int min = 1, max = 1000;
            while (true)
            {
                Console.Write("Nhap so dong va so cot: ");
                string line = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("Gia tri khong duoc de trong. Vui long nhap lai.");
                    continue;
                }

                string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    Console.WriteLine("Nhap sai dinh dang. Vui long nhap theo kieu: n m");
                    continue;
                }

                if (!BigInteger.TryParse(parts[0], out BigInteger r) ||
                    !BigInteger.TryParse(parts[1], out BigInteger c))
                {
                    Console.WriteLine("Vui long nhap so nguyen hop le.");
                    continue;
                }

                if (r < min || r > max || c < min || c > max)
                {
                    Console.WriteLine($"Gia tri phai nam trong khoang [{min}, {max}].");
                    continue;
                }

                return ((int)r, (int)c);
            }
        }

        private static int[,] InputMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int min = -1000000, max = 1000000;
            Console.WriteLine($"Nhap ma tran {rows} dong {cols} cot:");

            for (int i = 0; i < rows; i++)
            {
                while (true)
                {
                    string line = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        Console.WriteLine("Dong nay khong duoc de trong. Vui long nhap lai.");
                        continue;
                    }

                    string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != cols)
                    {
                        Console.WriteLine($"Vui long nhap dung {cols} so cho dong nay.");
                        continue;
                    }

                    bool valid = true;
                    for (int j = 0; j < cols; j++)
                    {
                        if (!BigInteger.TryParse(parts[j], out BigInteger value))
                        {
                            Console.WriteLine("Chi duoc nhap so nguyen. Vui long nhap lai dong nay.");
                            valid = false;
                            break;
                        }

                        if (value < min || value > max)
                        {
                            Console.WriteLine($"Gia tri tai cot {j + 1} phai nam trong khoang [{min}, {max}]. Vui long nhap lai dong nay.");
                            valid = false;
                            break;
                        }

                        matrix[i, j] = (int)value;
                    }

                    if (valid) break;
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            Console.WriteLine("\nNoi dung ma tran:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        private static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            int limit = (int)Math.Sqrt(x);
            for (int i = 3; i <= limit; i += 2)
                if (x % i == 0) return false;
            return true;
        }

        private static void SearchElement(int[,] matrix, int value)
        {
            bool found = false;
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] == value)
                    {
                        Console.WriteLine($"Tim thay {value} tai vi tri dong {i}, cot {j}");
                        found = true;
                    }

            if (!found)
                Console.WriteLine($"Khong tim thay {value} trong ma tran.");
        }

        private static void PrintPrimeElements(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            bool found = false;

            Console.WriteLine("\nCac phan tu la so nguyen to:");
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (IsPrime(matrix[i, j]))
                    {
                        Console.Write(matrix[i, j] + " ");
                        found = true;
                    }

            if (!found)
                Console.WriteLine("Khong co so nguyen to nao trong ma tran.");
            else
                Console.WriteLine();
        }

        private static int FindRowWithMostPrimes(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int maxCount = 0, maxRow = 0;

            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                    if (IsPrime(matrix[i, j]))
                        count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    maxRow = i;
                }
            }
            return maxRow;
        }

        static void Main()
        {
            var (n, m) = InputMatrixSize();
            int[,] matrix = InputMatrix(n, m);

            PrintMatrix(matrix);

            int value = CheckInput("\nNhap gia tri can tim: ", -1000000, 1000000);
            SearchElement(matrix, value);

            PrintPrimeElements(matrix);

            int row = FindRowWithMostPrimes(matrix);
            Console.WriteLine($"\nDong {row} co nhieu so nguyen to nhat.");

            Console.ReadLine();
        }
    }
}
