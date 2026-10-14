using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Họ và tên: ");
        string hoTen = Console.ReadLine() ?? "";
        Console.Write("Năm sinh: ");
        int namSinh;
        if (!int.TryParse(Console.ReadLine(), out namSinh))
        {
            Console.WriteLine("Năm sinh không hợp lệ.");
            return;
        }
        int namHienTai = DateTime.Now.Year;
        if (namSinh <= 0 || namSinh > namHienTai)
        {
            Console.WriteLine("Năm sinh không hợp lệ.");
            return;
        }
        int tuoi = namHienTai - namSinh;
        Console.WriteLine($"Họ tên: {hoTen}");
        Console.WriteLine($"Năm sinh: {namSinh}");
        Console.WriteLine($"Tuổi gần đúng: {tuoi}");
    }
}