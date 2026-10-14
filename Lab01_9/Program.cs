using System;

class Program
{
    static string DocDonVi(int n)
    {
        switch (n)
        {
            case 0: return "không";
            case 1: return "một";
            case 2: return "hai";
            case 3: return "ba";
            case 4: return "bốn";
            case 5: return "năm";
            case 6: return "sáu";
            case 7: return "bảy";
            case 8: return "tám";
            case 9: return "chín";
            default: return "";
        }
    }

    static string DocSo(int n)
    {
        if (n < 0 || n > 99)
            return "Số không hợp lệ!";

        if (n < 10)
            return DocDonVi(n);

        int chuc = n / 10;
        int donVi = n % 10;

        string ketQua;

        if (chuc == 1)
            ketQua = "mười";
        else
            ketQua = DocDonVi(chuc) + " mươi";

        if (donVi == 0)
            return ketQua;

        if (donVi == 1 && chuc >= 2)
            ketQua += " mốt";
        else if (donVi == 4 && chuc >= 2)
            ketQua += " tư";
        else if (donVi == 5)
            ketQua += " lăm";
        else
            ketQua += " " + DocDonVi(donVi);

        return ketQua;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số từ 0 đến 99: ");

        if (!int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Dữ liệu không hợp lệ!");
            return;
        }

        Console.WriteLine("Cách đọc: " + DocSo(n));
    }
}