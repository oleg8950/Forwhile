using System;
namespace Oleg
{
    public class MainClass
    {
        static void Main()
        {
            For8();
        }
        public static double For4()
        {
            double price = 2;
            for (int i = 1; i <= 10; i++)
            {
                price = price * i;
                Console.WriteLine(price);
                price = 2;
            }
            return price;
        }
        public static int For8()
        {
            int a = 5;
            int b = 10;
            int c = 1;
            for (int i = a; i <= b && i >= a; i++)
            {
                c = c * i;
            }
            Console.WriteLine(c);
            return c;
        }
        static void for12()
        {
            int n = 6;
            double sum = 1.0;
            for (double i = 1; i <= n; i++)
            {
                sum = sum * (1 + i / 10);
            }
            Console.WriteLine(sum);
        }
        static void for16()
        {
            double a = 5;
            int n = 3;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(a, i));
            }
        }
        static void for20()
        {
            double n = 4;
            double n1 = 1;
            double sumofn1 = 0;
            for (double i = 1; i <= n; i++)
            {
                n1 = n1 * i;
                sumofn1 = sumofn1 + n1;
            }
            Console.WriteLine(sumofn1);
        }
        static void For24()
        {
            int n = 5;
            double x, rez, factorial, pow;
            rez = 1;
            factorial = 1;
            pow = 1;
            x = 5;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
                pow = pow * x;
                if (i % 2 == 0)
                {
                    pow = pow * (-1);
                    rez = rez + pow / factorial;
                }
            }
            Console.WriteLine(rez);
        }
        static void For28()
        {
            int n, i;
            double x, rez, pow, temp1, temp2;
            x = 5;
            n = 7;
            rez = 1;
            pow = 1;
            temp1 = 1;
            temp2 = 1;
            for (i = 1; i <= n; i++)
            {
                temp1 = temp1 * (2 * i - 3);
                temp2 = temp2 * (2 * i);
                pow = pow * x * (-1);
                rez = rez + temp1 * pow / temp2;

            }
            Console.WriteLine(rez);
        }
        static void For32()
        {
            int n = 5;
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = (a + i) / 7;
            }
            Console.WriteLine(a);
        }
        static void for36()
        {
            double n = 4;
            double k = 5;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + Math.Pow(i, k);
            }
            Console.WriteLine(sum);
        }
        static void For40()
        {
            int a = 4;
            int b = 6;
            int c = b - a;
            for (int i = 0; i <= c; i++)
            {
                for (int i2 = 0; i2 <= i; i++)
                {
                    Console.WriteLine(a + i);
                }
            }
        }
       
        public static int While4()
        {
           int  N = 6;
            if (N % 3 != 0)
            {
                N %= 3;
                return (1);
            }
            else
                return (0);
        }
        static void While12()
        {
            double n, k, l;
            n = 76;
            k = 0;
            l = 0;
            while (l + k + 1 >= n)
                k++;
            l = l + k;
            Console.WriteLine(k);
            Console.WriteLine(l);
        }
        static void While16()
        {
            double p, d, s, k;
            p = 16;
            k = 1;
            d = 10;
            s = 10;
            while (s <= 200)
                k++;
            d = d + d * p / 100;
            s = s + d;
            Console.WriteLine(k);
            Console.WriteLine(s);
        }
        static void While20()
        {
            int n;
            bool c;
            c = false;
            n = 5;
            while (n > 0)
            {
                if (n / 10 == 2)
                {
                    c = true;
                    n = n / 10;
                }
            }

            Console.WriteLine(c);
        }
        static void While24()
        {
            double n, f, f1, f2;
            n = 18;
            f1 = 1;
            f = 0;
            f2 = 1;
            while (f < n)
                f = f2 + f1;
            f2 = f1;
            f1 = f;
            Console.WriteLine(f = n);

        }

        static void While28()
        {
            double k, ak1, ak, e;
            e = 10;
            ak1 = 0;
            ak = 2;
            k = 1;
            while (Math.Abs(ak - ak1) >= e)
                k++;
            ak1 = ak;
            ak = 2 + 1 / ak1;
            Console.WriteLine(k);
            Console.WriteLine(ak);
            Console.WriteLine(ak1);
        }
    }
}
