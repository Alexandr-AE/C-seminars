// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


decimal Input(string message)
{
    System.Console.Write(message);
    decimal num = Convert.ToDecimal(Console.ReadLine());
    return num;
}
void IntersectionPoint(decimal b1, decimal k1, decimal b2, decimal k2)
{
    if (k1 == k2 && b1 == b2)
        System.Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
        System.Console.WriteLine($"Прямые, заданные уравнениями y = {k1} * x + {b1} и y = {k2} * x + {b2} -> параллельные");
    else
    {
        decimal x = (b2 - b1) / (k1 - k2);
        decimal y = k1 * x + b1;
        System.Console.WriteLine($"Точка пересечения прямых, заданных уравнениями y = {k1} * x + {b1} и y = {k2} * x + {b2} -> ({x:F3}; {y:F3})");
    }
}


decimal b1 = Input("Введите значение b1: ");
decimal k1 = Input("Введите значение k1: ");
decimal b2 = Input("Введите значение b2: ");
decimal k2 = Input("Введите значение k2: ");
IntersectionPoint(b1, k1, b2, k2);