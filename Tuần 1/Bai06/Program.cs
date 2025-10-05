//6.Viết chương trình cho phép tạo ma trận chứa các số nguyên ngẫu nhiên gồm n 
//dòng, m cột. Cài đặt hàm thực hiện các chức năng sau: 
//a.Xuất ma trận 
//b. Tìm phần tử lớn nhất/nhỏ nhất 
//c. Tìm dòng có tổng lớn nhất 
//d. Tính tổng các số không phải là số nguyên tố 
//e. Xóa dòng thứ k trong ma trận 
//f. Xóa cột chứa phần tử lớn nhất trong ma trận 
using System;
using System.Numerics;

namespace Bai06
{
    class Program
    {
        private static int CheckInput(string s, int min, int max)
        {
            BigInteger value;
            while (true)
            {
                Console.WriteLine(s);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong.");
                    continue;
                }

                if (!BigInteger.TryParse(input, out value))
                {
                    Console.WriteLine("Vui long nhap so nguyen.");
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.WriteLine($"Gia tri phai nam trong khoang [{min}, {max}]");
                    continue;
                }

                return (int)value;
            }
        }

        private static int[,] Matrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(-1000, 1001);
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j] + "\t");
                Console.WriteLine();
            }
        }

        private static int FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
            return max;
        }

        private static int FindMin(int[,] matrix)
        {
            int min = matrix[0, 0];
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
            return min;
        }

        private static int FindMaxRow(int[,] matrix)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            int maxRowIndex = 0;
            int maxSum = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++) sum += matrix[i, j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRowIndex = i;
                }
            }
            return maxRowIndex;
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

        private static BigInteger SumNonPrimes(int[,] matrix)
        {
            BigInteger sum = 0;
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (!IsPrime(matrix[i, j]))
                        sum += matrix[i, j];
            return sum;
        }

        private static int[,] DeleteRow(int[,] matrix, int k)
        {
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);
            if (k < 0 || k >= rows) return matrix;
            int[,] result = new int[rows - 1, cols];
            int r = 0;
            for (int i = 0; i < rows; i++)
            {
                if (i == k) continue;
                for (int j = 0; j < cols; j++)
                    result[r, j] = matrix[i, j];
                r++;
            }
            return result;
        }

        private static int[,] DeleteColumnWithMax(int[,] matrix)
        {
            int max = FindMax(matrix);
            int rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            int colToDelete = -1;
            for (int i = 0; i < rows && colToDelete == -1; i++)
                for (int j = 0; j < cols; j++)
                    if (matrix[i, j] == max)
                    {
                        colToDelete = j;
                        break;
                    }

            if (colToDelete == -1) return matrix;

            int[,] result = new int[rows, cols - 1];
            for (int i = 0; i < rows; i++)
            {
                int c = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j == colToDelete) continue;
                    result[i, c] = matrix[i, j];
                    c++;
                }
            }
            return result;
        }
        private static (int rows, int cols) CheckMatrixSize(string s)
        {
            int min = 1;
            int max = 1000;
            while (true)
            {
                Console.Write(s);
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Gia tri khong duoc de trong.");
                    continue;
                }

                string[] parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                {
                    Console.WriteLine("Vui long nhap theo dinh dang n dong, m cot.\n");
                    continue;
                }

                if (!BigInteger.TryParse(parts[0], out BigInteger rowsBI) ||
                    !BigInteger.TryParse(parts[1], out BigInteger colsBI))
                {
                    Console.WriteLine("Vui long nhap so nguyen.");
                    continue;
                }

                if (rowsBI < min || rowsBI > max || colsBI < min || colsBI > max)
                {
                    Console.WriteLine($"Gia tri phai nam trong khoang [{min}, {max}].");
                    continue;
                }

                return ((int)rowsBI, (int)colsBI);
            }
        }


        static void Main(string[] args)
        {
            var (n, m) = CheckMatrixSize("Nhap n dong va n cot: ");

            int[,] matrix = Matrix(n, m);
            Console.WriteLine($"\nMa tran {n} x {m}:");
            PrintMatrix(matrix);

            Console.WriteLine("\nPhan tu lon nhat: " + FindMax(matrix));
            Console.WriteLine("Phan tu nho nhat: " + FindMin(matrix));

            int maxRow = FindMaxRow(matrix);
            Console.WriteLine($"Dong {maxRow} co tong so lon nhat.");

            Console.WriteLine("Tong cac so khong phai so nguyen to: " + SumNonPrimes(matrix));

            int k = CheckInput("Nhap dong muon xoa:", 0, n - 1);
            matrix = DeleteRow(matrix, k);
            Console.WriteLine("\nMa tran sau khi xoa dong thu k:");
            PrintMatrix(matrix);

            matrix = DeleteColumnWithMax(matrix);
            Console.WriteLine("\nMa tran sau khi xoa cot chua phan tu lon nhat:");
            PrintMatrix(matrix);

            Console.ReadLine();
        }
    }
}
