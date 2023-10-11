using MVkyrsachCA.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachCA.Methods
{
    internal class ParabolaMethod : Function, Output
    {
        double lower, upper, step, result = 0;
        int n;
        public ParabolaMethod(double _lower, double _upper, int _n)
        {
            lower = _lower;
            upper = _upper;
            n = _n;
            step = (upper - lower) / 50;
        }

        public double func(double x)
        {
            return 1 / Math.Log(x);
        }

        public double Parabola()
        {
            int i;
            double[] x = new double[n + 1];
            for (i = 0; i < n; i++)
            {
                x[i] = lower + step * i;
            }
            result = step * (func(x[0]) + func(x[n])) / 3;
            for (i = 1; i < (n - 1); i = i + 2)
            {
                result = result + step * 4 * func(x[i]) / 3;
            }
            for (i = 2; i < (n - 2); i = i + 2)
            {
                result = result + step * 2 * func(x[i]) / 3;
            }
            return result;
        }

        public void Print()
        {
            Console.WriteLine("Решим определенный интеграл 1/ln(x)\n" +
                $"Нижняя граница {lower} \n" +
                $"Верхняя граница {upper} \n" +
                $"Количество точек {n} \n" +
                $"Решив методом парабол, получим значение {Parabola()}");
        }
    }
}
