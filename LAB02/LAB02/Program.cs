using System;

namespace LAB2
{
    class Program
    {
        // Nhập mảng với tham số n
        public static void NhapMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        // Tính tổng các phần tử
        public static int TinhTong(int[] a, int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        // Bài 1: Tính tổng số chẵn
        public static int TongChan(int[] a)
        {
            int tong = 0;
            foreach (int x in a)
                if (x % 2 == 0)
                    tong += x;
            return tong;
        }

        // Bài 2: Kiểm tra số nguyên tố
        public static bool LaSoNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        public static void HienThiSoNguyenTo(int[] a)
        {
            Console.WriteLine("Các số nguyên tố trong mảng:");
            for (int i = 0; i < a.Length; i++)
                if (LaSoNguyenTo(a[i]))
                    Console.WriteLine($"a[{i}] = {a[i]}");
        }

        // Bài 3: Đếm số âm và dương
        public static void DemAmDuong(int[] a, out int demAm, out int demDuong)
        {
            demAm = 0; demDuong = 0;
            foreach (int x in a)
            {
                if (x < 0) demAm++;
                else if (x > 0) demDuong++;
            }
        }

        // Bài 4: Tìm số lớn thứ hai
        public static int TimSoLonThuHai(int[] a)
        {
            int max = int.MinValue, secondMax = int.MinValue;
            foreach (int x in a)
            {
                if (x > max)
                {
                    secondMax = max;
                    max = x;
                }
                else if (x > secondMax && x != max)
                    secondMax = x;
            }
            return secondMax;
        }

        // Bài 5: Hoán vị 2 số
        public static void HoanVi(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Bài 6: Sắp xếp mảng số thực tăng dần
        public static void SapXepTang(float[] a)
        {
            Array.Sort(a);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ===== PHẦN GỐC: Tính tổng mảng =====
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            NhapMang(a, n);
            Console.WriteLine($"Tổng = {TinhTong(a, n)}");

            // ===== Bài 1: Tổng số chẵn =====
            Console.WriteLine($"\nTổng các số chẵn: {TongChan(a)}");

            // ===== Bài 2: Hiển thị số nguyên tố =====
            HienThiSoNguyenTo(a);

            // ===== Bài 3: Đếm số âm và dương =====
            DemAmDuong(a, out int am, out int duong);
            Console.WriteLine($"\nSố âm: {am}, Số dương: {duong}");

            // ===== Bài 4: Số lớn thứ hai =====
            int max2 = TimSoLonThuHai(a);
            Console.WriteLine($"\nSố lớn thứ hai: {max2}");

            // ===== Bài 5: Hoán vị hai số =====
            Console.Write("\nNhập số a: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập số b: ");
            int y = int.Parse(Console.ReadLine());
            HoanVi(ref x, ref y);
            Console.WriteLine($"Sau hoán vị: a = {x}, b = {y}");

            // ===== Bài 6: Sắp xếp mảng số thực =====
            Console.Write("\nNhập số phần tử mảng thực: ");
            int m = int.Parse(Console.ReadLine());
            float[] b = new float[m];
            for (int i = 0; i < m; i++)
            {
                Console.Write($"b[{i}]: ");
                b[i] = float.Parse(Console.ReadLine());
            }
            SapXepTang(b);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (float val in b)
                Console.Write(val + " ");
        }
    }
}
