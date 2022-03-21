using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary
{
    public class KvLUr
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="message"></param>
        public static void KvUr(double a, double b, double c, out string message)
        {
            double d = 0, x1 = 0, x2 = 0;

            if (a == 0)
            {
                LUr(b, c, out message);
            }
            else
            {
                d = b * b - 4 * a * c;
                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    message = $"Два корня: x1 = {x1}, x2 = {x2}";
                }
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    message = $"Один корень: x = {x1}";
                }
                else
                {
                    message = "Нет корней";
                }
            }
        }

        public static void LUr(double k, double b, out string message)
        {
            double x = 0;
            if (k == 0)
            {
                if (b == 0)
                    message = "Прямая совпадает с осью";
                else
                    message = "Нет решений";
            }
            else
            {
                x = -b / k;
                message = $"Корень: x = {x}";
            }
        }
    }
}
