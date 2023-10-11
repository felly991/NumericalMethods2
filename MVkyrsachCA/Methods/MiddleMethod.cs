using MVkyrsachCA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachCA.Methods
{
    internal class MiddleMethod : Output, Function
    {
        double lower, upper, step, result = 0;
        int n;
        public MiddleMethod(double _lower, double _upper, int _n)
        {
            lower = _lower;
            upper = _upper;
            step = (upper - lower) / 50;
            n = _n;
        }

        public double func(double x)
        {
            return 1 / Math.Log(x);
        }

        public double Middle()
        {
            var sum = (func(lower) + func(upper)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = lower + step * i;
                sum += func(x);
            }

            var result = step * sum;
            return result;
        }

        public void Print()
        {
            Console.WriteLine("Решим определенный интеграл 1/ln(x)\n" +
                $"Нижняя граница {lower} \n" +
                $"Верхняя граница {upper} \n" +
                $"Количество точек {n} \n" +
                $"Решив методом средних прямоугольников, получим значение {Middle()}");
        }
    }
}
