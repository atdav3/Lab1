using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            Console.Write("Nhập a = ");
            int a = int.Parse(Console.ReadLine() ?? "");

            Console.Write("Nhập b = ");
            int b = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"a / b = {(double)a / b}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Dữ liệu phải là số nguyên!");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Không thể chia cho 0!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Số nhập vào vượt quá giới hạn!");
        }
        finally
        {
            Console.WriteLine("Kết thúc phép tính.");
        }
    }
}