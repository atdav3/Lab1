using System;

class Program
{
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= n / i; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập n = ");

        if (!int.TryParse(Console.ReadLine(), out int n) || n < 2)
        {
            Console.WriteLine("Vui lòng nhập n >= 2!");
            return;
        }

        Console.WriteLine($"Các số nguyên tố không vượt quá {n}:");

        for (int i = 2; i <= n; i++)
        {
            if (LaSoNguyenTo(i))
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}