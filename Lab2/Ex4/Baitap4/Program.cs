using System;

namespace KiemTraTamGiac
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.Write("Nhập chiều dài cạnh a: ");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nhập chiều dài cạnh b: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Nhập chiều dài cạnh c: ");
                        double c = Convert.ToDouble(Console.ReadLine());

                        if (LaTamGiac(a, b, c))
                        {
                                Console.WriteLine("Ba số là chiều dài của ba cạnh của một tam giác.");
                                XacDinhLoaiTamGiac(a, b, c);
                        }
                        else
                        {
                                Console.WriteLine("Ba số không tạo thành tam giác.");
                        }
                }

                static bool LaTamGiac(double a, double b, double c)
                {
                        return a + b > c && a + c > b && b + c > a;
                }

                static void XacDinhLoaiTamGiac(double a, double b, double c)
                {
                        if (a == b && b == c)
                                Console.WriteLine("Tam giác đều.");
                        else if (a == b || b == c || a == c)
                                Console.WriteLine("Tam giác cân.");
                        else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                                Console.WriteLine("Tam giác vuông.");
                        else
                                Console.WriteLine("Tam giác thường.");
                }
        }
}
