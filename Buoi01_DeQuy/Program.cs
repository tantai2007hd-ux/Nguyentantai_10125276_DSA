using System;
using System;
using System.ComponentModel.DataAnnotations;
/*
class Program
{
    static void Main()
    {
        Random rd = new Random();
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(1, 1001);
        }
        int max = a[0];
        int min = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        Console.WriteLine("So lon nhat trong mang la: {0}", max);
        Console.Write("So be nhat trong mang la: {0}", min);
    }
}
class Porgram
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        char[] a = s.ToCharArray();
        int left = 0;
        int right = a.Length - 1;
        while(left < right)
        {
            char temp = a[left];
            a[left] = a[right];
            a[right] = temp;
            left++;
            right--;
        }
        string Ketqua = new string(a);
        Console.Write("Ket qua sau khi dao nguoc: {0}", Ketqua);
    }
}
class Program
{
    static void Main()
    {
        Random rd = new Random();
        int n = 0;
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(1, 1001);
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(" {0}",a[i]);
        }
        for (int i = 0; i < a.Length - 1; i++)
        {
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];    
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        Console.Write("Mang sau khi sap xep:");
        for(int i = 0; i < a.Length; i++)
        {
            Console.Write(" {0}", a[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        int n;
        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());
        int a = 0;
        long b = 1;
        if (n == 0)
        {
            Console.Write("Fibo = 0");
            return;
        }
        if (n == 1)
        {
            Console.Write("Fibo = 1");
            return;
        }
        for(int i = 0; i <= n; i++)
        {
            long c = a + b;
            a = b;
            b = c;
        }
        Console.Write("Day Fibo: {0}", b);
    }
}
*/
