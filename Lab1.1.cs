using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập số bài muốn chạy (1-10): ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1": BAI1(); break;
            case "2": BAI2(); break;
            case "3": BAI3(); break;
            case "4": BAI4(); break;
            case "5": BAI5(); break;
            case "6": BAI6(); break;
            case "7": BAI7(); break;
            case "8": BAI8(); break;
            case "9": BAI9(); break;
            case "10": BAI10(); break;
            default: Console.WriteLine("Không có bài này."); break;
        }
    }

    static void BAI1()
    {
        Console.Write("Nhập tên của bạn: ");
        string ten = Console.ReadLine();

        Console.Write("Nhập tuổi của bạn: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi!");
    }

    static void BAI2()
    {
        Console.Write("Nhập chiều dài: ");
        double dai = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều rộng: ");
        double rong = double.Parse(Console.ReadLine());

        Console.WriteLine($"Diện tích: {dai * rong}");
    }

    static void BAI3()
    {
        Console.Write("Nhập nhiệt độ (°C): ");
        double c = double.Parse(Console.ReadLine());

        double f = (c * 9 / 5) + 32;
        Console.WriteLine($"Nhiệt độ (°F): {f}");
    }

    static void BAI4()
    {
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n % 2 == 0 ? "Số chẵn" : "Số lẻ");
    }

    static void BAI5()
    {
        Console.Write("Nhập số thứ nhất: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tổng: {a + b}");
        Console.WriteLine($"Tích: {a * b}");
    }

    static void BAI6()
    {
        Console.Write("Nhập một số: ");
        double n = double.Parse(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Số dương");
        else if (n < 0)
            Console.WriteLine("Số âm");
        else
            Console.WriteLine("Số 0");
    }

    static void BAI7()
    {
        Console.Write("Nhập một năm: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine($"{year} là năm nhuận.");
        else
            Console.WriteLine($"{year} không phải là năm nhuận.");
    }

    static void BAI8()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nBảng cửu chương của {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
    }

    static void BAI9()
    {
        Console.Write("Nhập một số nguyên dương: ");
        int n = int.Parse(Console.ReadLine());

        long gt = 1;
        for (int i = 1; i <= n; i++)
        {
            gt *= i;
        }

        Console.WriteLine($"Giai thừa của {n} là: {gt}");
    }

    static void BAI10()
    {
        Console.Write("Nhập một số nguyên: ");
        int n = int.Parse(Console.ReadLine());

        bool nguyenTo = n > 1;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                nguyenTo = false;
                break;
            }
        }

        Console.WriteLine(nguyenTo ? "Là số nguyên tố" : "Không phải số nguyên tố");
    }
}
