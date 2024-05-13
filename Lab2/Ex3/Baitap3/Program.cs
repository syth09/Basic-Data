using System;

namespace KiemTraSoNguyenTo
{
        class Program
        {
                static bool LaSoNguyenTo(int n)
                {
                        if (n < 2)
                                return false;

                        for (int i = 2; i <= Math.Sqrt(n); i++)
                        {
                                if (n % i == 0)
                                        return false;
                        }

                        return true;
                }

                static void Main(string[] args)
                {
                        Console.Write("Nhập một số nguyên dương: ");
                        int so = Convert.ToInt32(Console.ReadLine());

                        if (LaSoNguyenTo(so))
                                Console.WriteLine($"{so} là số nguyên tố.");
                        else
                                Console.WriteLine($"{so} không là số nguyên tố.");
                }
        }
}
