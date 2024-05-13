using System;

namespace TinhTongDaySo
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Write("Nhập giá trị n: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        int tong = 0;
                        for (int i = 2; i <= n; i += 2)
                        {
                                tong += i;
                        }

                        Console.WriteLine($"Tổng của dãy số là: {tong}");
                }
        }
}