// low = 2 hing = 5 1/ln(x)

using MVkyrsachCA.Methods;
void Info()
{
    Console.WriteLine("Вaш определенный интеграл 1/ln(x) \n" +
        "Нижняя граница 2 \n" +
        "Верхняя граница 5 \n" +
        "Выберите метод решения: \n" +
        "1 - Метод левых прямоугольников \n" +
        "2 - Метод правых прямоугольников \n" +
        "3 - Метод средних прямоульников \n" +
        "4 - Метод трапеций \n" +
        "5 - Метод парабол \n" +
        "exit - выход");
}
Info();
string? answer = Console.ReadLine();
while (answer != "exit")
{
    switch (answer)
    {
        case "1":
            new LeftMethod(2, 5, 50).Print();
            Console.WriteLine("__________________");
            break;
        case "2":
            new RightMethod(2, 5, 50).Print();
            Console.WriteLine("__________________");
            break;
        case "3":
            new MiddleMethod(2, 5, 50).Print();
            Console.WriteLine("__________________");
            break;
        case "4":
            new TrapezoidMethod(2, 5, 50).Print();
            Console.WriteLine("__________________");
            break;
        case "5":
            new ParabolaMethod(2, 5, 50).Print();
            Console.WriteLine("__________________");
            break;
        default:
            Console.WriteLine("Неверный ввод данных");
            break;
    }
    answer = Console.ReadLine();
}


