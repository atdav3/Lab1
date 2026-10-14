
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out double r) || r <= 0)
            {
                Console.WriteLine("Bán kính không hợp lệ!");
                return;
            }

            Console.Write("Nhập chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out double h) || h <= 0)
            {
                Console.WriteLine("Chiều cao không hợp lệ!");
                return;
            }

            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;

            Console.WriteLine($"Diện tích xung quanh = {dienTichXQ:F2}");
            Console.WriteLine($"Thể tích = {theTich:F2}");

            Console.ReadKey();
        }
    }
}
