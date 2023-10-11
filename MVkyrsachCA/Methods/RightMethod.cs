using MVkyrsachCA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachCA.Methods
{
    internal class RightMethod : Function, Output
    {

        double lower, upper, step, result = 0;
        int n;
        public RightMethod(double _lower, double _upper, int n)
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

        public double Right()
        {
            for (double x = lower; x <= upper; x += step)
            {
                result += func(x + step) * step;                    
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine("Решим определенный интеграл 1/ln(x)\n" +
                $"Нижняя граница {lower} \n" +
                $"Верхняя граница {upper} \n" +
                $"Количество точек {n} \n" +
                $"Решив методом правых прямоугольников, получим значение {Right()}");
        }
    }
}
