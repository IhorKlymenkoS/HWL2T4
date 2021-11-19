using System;

namespace Task4
{
    class Program
    {
        static string Task1(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            double x1 = 1;
            double x2 = 1;
            string k = "";
            {
                if (a != 0)
                {
                    if (d > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / 2 * a;
                        x2 = (-b - Math.Sqrt(d)) / 2 * a;
                        k = "two roots" + Environment.NewLine+
                            x1 + Environment.NewLine + x2;

                    }
                    else if (d == 0)
                    {
                      x1 = -b/2*a;
                      k = "one roots" + Environment.NewLine + x1;
                    }
                    else
                    {
                        k = "no roots";
                    }
                }


            }

            return  k;
        }
        static void Main(string[] args)
        {
            string k = Task1(22, 66, 3);
            Console.WriteLine(k);
        }
    }
}
