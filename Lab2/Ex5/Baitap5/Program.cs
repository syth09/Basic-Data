using System;

namespace ChuoiFibonacci
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Write("Nhập số n: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        // Khởi tạo hai số đầu tiên của chuỗi Fibonacci
                        int a = 0;
                        int b = 1;

                        Console.Write("Chuỗi Fibonacci: ");

                        // Hiển thị n số đầu tiên của chuỗi Fibonacci
                        for (int i = 0; i < n; i++)
                        {
                                Console.Write(a + " ");

                                int temp = a;
                                a = b;
                                b = temp + b;
                        }

                        Console.WriteLine();
                }
        }
}
