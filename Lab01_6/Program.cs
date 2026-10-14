using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập a = ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("Dữ liệu không hợp lệ!");
            return;
        }

        Console.Write("Nhập b = ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("Dữ liệu không hợp lệ!");
            return;
        }

        Console.Write("Nhập c = ");
        if (!double.TryParse(Console.ReadLine(), out double c))
        {
            Console.WriteLine("Dữ liệu không hợp lệ!");
            return;
        }

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0
                    ? "Phương trình vô số nghiệm."
                    : "Phương trình vô nghiệm.");
            }
            else
            {
                Console.WriteLine($"Phương trình có nghiệm x = {-c / b:F2}");
            }

            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Nghiệm kép x = {x:F2}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"x1 = {x1:F2}");
            Console.WriteLine($"x2 = {x2:F2}");
        }
    }
}