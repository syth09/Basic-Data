using System;

namespace TinhTongDaySoPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập giá trị n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += 1.0 / i;
            }

            Console.WriteLine($"Tổng của dãy số là: {tong}");
        }
    }
}
