using System;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace program
{
    public static class Tasks
    {
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
    }
}