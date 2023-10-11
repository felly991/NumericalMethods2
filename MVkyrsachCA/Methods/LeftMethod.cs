using MVkyrsachCA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachCA.Methods
{
    internal class LeftMethod : Function, Output
    {
        double lower, upper, step, result = 0;
        int n;
        public LeftMethod(double _lower, double _upper, int n)
        {
            lower = _lower;
            upper = _upper;
            step = (upper - lower) / 50;
            this.n = n;

        }

        public double func(double x)
        {
            return 1 / Math.Log(x);
        }

        public double Left()
        {
            for (double x = lower; x < upper; x += step)
            {
                result += func(x) * step;                         
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine("Решим определенный интеграл 1/ln(x)\n" +
                $"Нижняя граница {lower} \n" +
                $"Верхняя граница {upper} \n" +
                $"Количество точек {n} \n" +
                $"Решив методов левых прямоугольников, получим значение {Left()}");
        }
    }
}
