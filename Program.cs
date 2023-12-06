using System;
using System.Globalization;
namespace Usingoperator;
public class Program
{
    private static void Main(string[] args)
    {
        float chieurong;
        float chieudai;
        Console.WriteLine("Nhap thong so cho hinh chu nhat: ");
        Console.WriteLine("Nhap chieu rong: ");
        chieurong = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu dai: ");
        chieudai = float.Parse(Console.ReadLine());
        Console.WriteLine("Dien tich hinh chu nhat la: " + chieudai*chieurong);
    }
}