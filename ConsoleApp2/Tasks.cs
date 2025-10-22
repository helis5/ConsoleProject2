using System;
using System.Formats.Asn1;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace program
{
    public static class Tasks
    {

        public static double Factorial(double number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }

        public static void t77(int n)
        {
            double x = 1;
            for (double i = 1; i <= n; i++) x *= 1 + 1 / (i * i);
            Console.WriteLine($"77) {x}");
        }

        public static void t78(int n, double a)
        {
            Console.WriteLine("");

            double x = a;
            for (double i = 1; i <= n; i++) x *= a;
            Console.WriteLine($"78a) {x}");

            x = a;
            for (double i = 1; i <= n; i++) x *= a - i;
            Console.WriteLine($"78б) {x}");

            x = 1 / a; double z = a;
            for (double i = 1; i <= n; i++)
            {
                z *= a + i;
                x += 1 / z;
            }
            Console.WriteLine($"78в) {x}");

            x = 1 / a;
            for (double i = 1; i <= n; i++) x += 1 / Math.Pow(a, Math.Pow(2, i));
            Console.WriteLine($"78г) {x}");

            x = a;
            for (double i = 1; i <= n; i++) x *= a - (i * n);
            Console.WriteLine($"78д) {x}");
        }

        public static void t79()
        {
            double x = 1;
            for (double i = 0.1; i < 10; i += 0.1) x *= 1 + Math.Sin(i);

            Console.WriteLine("");
            Console.WriteLine($"79) {x}");
        }
        public static void t80(double a)
        {
            double x = a; double r = a; double y = 1; double z = 1;
            for (double i = 2; i < 13; i++)
            {
                r = r * a * a;
                y += 2;
                z = z * y * (y - 1);
                x += (Math.Pow(-1, i + 1) * r) / z;
            }

            Console.WriteLine("");
            Console.WriteLine($"80) {x}");
        }
        public static void t81(int n, double a, double b)
        {

            double x = b + a;
            for (int i = 1; i <= n; i++) x = x * x + a;

            Console.WriteLine("");
            Console.WriteLine($"81) {x}");
        }
        public static void t82(double b)
        {

            double x = 1;
            for (double i = 2; i < 64; i += 2) x *= (b - i) / (b + 1 - i);

            Console.WriteLine("");
            Console.WriteLine($"82) {x}");
        }

        public static void t83(double a)
        {
            Console.WriteLine("");

            double x = 1;
            for (double i = 2; i < 64; i++)
            {
                if (x > a) { Console.WriteLine($"83) {x}"); break; }
                x += 1 / i;
            }

            if (x <= a) Console.WriteLine($"83) таких нет");

        }

        public static void t84(int n, double b)
        {
            Console.WriteLine("");

            double x = 1;
            for (int i = 1; i < n; i += 2) x += Math.Pow(Math.Sin(b), i);

            Console.WriteLine($"84a) {x}");

            x = 1;
            for (int i = 1; i < n; i += 2) x += Math.Sin(Math.Pow(b, i));

            Console.WriteLine($"84б) {x}");

            x = Math.Sin(b); double z = Math.Sin(b);
            for (int i = 1; i < n; i += 2)
            {
                z *= Math.Sin(b);
                x += z;
            }
            Console.WriteLine($"84в) {x}");
        }

        public static void t85(int n, double a, double b)
        {
            double f(double x)
            {
                return (x * x + 1) * Math.Cos(x) * Math.Cos(x);
            }

            double x = f(a);
            for (double i = 1; i < n; i += 1) x += 2 * f(a + i * b);

            Console.WriteLine("");
            Console.WriteLine($"85) {x}");

        }

        public static void t86(int n)
        {
            int z = n; int k = 0; int r = 0; int s = 0; int first = 0; int sznak = 0; int rr = r; int zn = 1;
            while (z > 0)
            {
                r = z % 10;
                s += r;
                zn *= -1;
                rr = r * zn;
                sznak += rr;
                first = r;
                z /= 10;
                k++;
            }

            Console.WriteLine("");
            Console.WriteLine($"86a) {k}");
            Console.WriteLine($"86б) {s}");
            Console.WriteLine($"86в) {first}");
            Console.WriteLine($"86г) {sznak}");
        }

        public static void t88(int n)
        {
            Console.WriteLine("");
            int z = n; int zz = n * n; int nobr = 0; int r = 0; bool bl = false;
            while (zz > 0)
            {
                r = zz % 10;
                if (r == 3) bl = true;
                zz /= 10;
            }

            while (z > 0)
            {
                r = z % 10;
                nobr = nobr * 10 + r;
                z /= 10;
            }

            string nstr = Convert.ToString(n); int l = nstr.Length;
            string result = nstr[nstr.Length - 1] + nstr.Substring(1, nstr.Length - 2) + nstr[0];
            Console.WriteLine($"88а) {bl}");
            Console.WriteLine($"88б) {nobr}");
            Console.WriteLine($"88в) {result}");
        }

        public static void t90(int n, int m)
        {
            static int F(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return a;
            }

            int f = F(m, n);
            int p = m / f;
            int q = n / f;

            Console.WriteLine($"90) p = {p}, q = {q}");
        }

        public static void t91(int n)
        {
            double a = 1;
            for (int i = 1; i < n; i++)
            {
                a = i * a + 1 / i;
            }
            Console.WriteLine($"91) a = {a}");
        }
        public static void t93(int n)
        {
            double a = 1;
            for (int i = 3; i < n; i++)
            {
                a = i * a + 1 / i;
            }
            Console.WriteLine($"93) a = {a}");
        }
        public static void t95()
        {
            double a2 = 1; double a1 = 1; double a = 0; double p = 1;
            for (int i = 2; i < 12; i++)
            {
                a = a2 + a1 / Math.Pow(2, i - 1);
                a2 = a1;
                a1 = a;

                p *= a;
            }
            Console.WriteLine($"95) p = {p}");
        }

        public static void t119(double eps)
        {
            double a1 = 0; double a = 1; double i = 2;
            while (Math.Abs(a1 - a) > eps)
            {
                a += 1 / (i * i);
                i++;
                a1 = a;
            }
            Console.WriteLine($"119a) s = {a}");

            a1 = 0; a = 1; i = 2;
            while (Math.Abs(a1 - a) > eps)
            {
                a += Math.Pow(-2, i) / Factorial(i);
                i++;
                a1 = a;
            }
            Console.WriteLine($"119г) s = {a}");
        }

        public static void k12(int n)
        {
            double a1 = 1; double a = 1;
            double b1 = 1; double b = 1;
            double s = 0;
            for (int i = 2; i < n; i++)
            {
                a = 5 * b1 + a1;
                b = 2 * a1 + b1;
                s += (a + b) / (2 + a * a + b * b);
                a1 = a;
                b1 = b;
            }
            Console.WriteLine($"k12) s = {s}");
        }
    }
}