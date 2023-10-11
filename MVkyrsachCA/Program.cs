using Microsoft.VisualBasic;
using MVkyrsachCA;
using MVkyrsachCA.Methods;

Console.WriteLine("Введите нижнюю границу");                 //2
double lower = double.Parse(Console.ReadLine());
Console.WriteLine("Введите верхнюю границу");                //5
double upper = double.Parse(Console.ReadLine());
Console.WriteLine("Введите шаг");                            //50
int step = int.Parse(Console.ReadLine());

MVkyrsachCA.Information.lower = lower;
MVkyrsachCA.Information.upper = upper;
MVkyrsachCA.Information.Info();

string? answer = Console.ReadLine();

while (answer != "exit")
{
    switch (answer)
    {
        case "1":
            new LeftMethod(lower, upper, step).Print();
            Console.WriteLine("__________________");
            break;
        case "2":
            new RightMethod(lower, upper, step).Print();
            Console.WriteLine("__________________");
            break;
        case "3":
            new MiddleMethod(lower, upper, step).Print();
            Console.WriteLine("__________________");
            break;
        case "4":
            new TrapezoidMethod(lower, upper, step).Print();
            Console.WriteLine("__________________");
            break;
        case "5":
            new ParabolaMethod(lower, upper, step).Print();
            Console.WriteLine("__________________");
            break;
        default:
            Console.WriteLine("Неверный ввод данных");
            break;
    }
    answer = Console.ReadLine();
}


