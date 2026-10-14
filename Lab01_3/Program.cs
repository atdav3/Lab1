using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập điểm: ");

        if (!double.TryParse(Console.ReadLine(), out double diem)
            || diem < 0 || diem > 10)
        {
            Console.WriteLine("Điểm phải nằm trong khoảng 0 đến 10!");
            return;
        }

        if (diem >= 9)
            Console.WriteLine("Xếp loại: Xuất sắc");
        else if (diem >= 8)
            Console.WriteLine("Xếp loại: Giỏi");
        else if (diem >= 6.5)
            Console.WriteLine("Xếp loại: Khá");
        else if (diem >= 5)
            Console.WriteLine("Xếp loại: Trung bình");
        else
            Console.WriteLine("Xếp loại: Yếu");
    }
}