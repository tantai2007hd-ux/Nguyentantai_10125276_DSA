using System;
/*
class Program
{
    static int S(int n)
    {
        if (n == 1)
            return 1;
        else
            return S(n - 1) + n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong S(n) = " + S(n));
    }
}
using System;

class Program
{
    static int S(int n)
    {
        if (n == 1)
            return 1;
        else
            return S(n - 1) + n * n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong binh phuong = " + S(n));
    }
}
using System;

class Program
{
    static double S(int n)
    {
        if (n == 1)
            return 1;
        else
            return S(n - 1) + 1.0 / n;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Tong nghich dao = " + S(n));
    }
}
using System;

class Program
{
    static double LuyThua(double x, int n)
    {
        if (n == 0)
            return 1;
        else
            return LuyThua(x, n - 1) * x;
    }

    static double S(double x, int n)
    {
        if (n < 0)
            return 1.0 / LuyThua(x, -n);
        else
            return LuyThua(x, n);
    }

    static void Main()
    {
        Console.Write("Nhap x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (x == 0 && n < 0)
            Console.WriteLine("Khong the tinh!");
        else
            Console.WriteLine("Ket qua = " + S(x, n));
    }
}
using System;

class Program
{
    static int UocLeMax(int n)
    {
        if (n % 2 == 1)
            return n;
        else
            return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Uoc le lon nhat = " + UocLeMax(n));
    }
}
using System;

class Program
{
    static int UCLN(int a, int b)
    {
        if (a % b == 0)
            return b;
        else
            return UCLN(b, a % b);
    }

    static void Main()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("UCLN = " + UCLN(a, b));
    }
}
using System;

class Program
{
    static int SoChuSo(int n)
    {
        if (n == 0)
            return 0;
        else
            return SoChuSo(n / 10) + 1;
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("So chu so = " + SoChuSo(n));
    }
}
using System;

class Program
{
    static double Can(int i, int n)
    {
        if (i == n)
            return Math.Sqrt(n);
        else
            return Math.Sqrt(i + Can(i + 1, n));
    }

    static double S(int n)
    {
        return Can(1, n);
    }

    static void Main()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
            Console.WriteLine("Nhap n >= 1!");
        else
            Console.WriteLine("S(n) = " + S(n));
    }
}
*/

