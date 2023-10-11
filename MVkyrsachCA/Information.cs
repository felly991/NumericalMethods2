using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachCA
{
    static class Information
    {
        public static double lower { get; set; }
        public static double upper { get; set; }
        
        public static void Info()
        {
            Console.WriteLine("Вaш определенный интеграл 1/ln(x) \n" +
            $"Нижняя граница {lower} \n" +
            $"Верхняя граница {upper} \n" +
            "Выберите метод решения: \n" +
            "1 - Метод левых прямоугольников \n" +
            "2 - Метод правых прямоугольников \n" +
            "3 - Метод средних прямоульников \n" +
            "4 - Метод трапеций \n" +
            "5 - Метод парабол \n" +
            "exit - выход");
        }
    }
}
