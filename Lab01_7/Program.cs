using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số lượng phần tử n = ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("n phải là số nguyên dương!");
            return;
        }

        long tong = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        int demChan = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Nhập số thứ {i}: ");

            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Dữ liệu không hợp lệ!");
                return;
            }

            tong += x;

            if (x > max)
                max = x;

            if (x < min)
                min = x;

            if (x % 2 == 0)
                demChan++;
        }

        double trungBinh = (double)tong / n;

        Console.WriteLine($"Tổng = {tong}");
        Console.WriteLine($"Trung bình = {trungBinh:F2}");
        Console.WriteLine($"Số lớn nhất = {max}");
        Console.WriteLine($"Số nhỏ nhất = {min}");
        Console.WriteLine($"Số lượng số chẵn = {demChan}");
    }
}