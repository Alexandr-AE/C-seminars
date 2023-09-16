// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
string SeriesNum(int num)
{
    if (num == 1)
        return "1";
    return $"{num}" + ", " + SeriesNum(num - 1);
}


int num = Input("Введите значение N: ");
System.Console.WriteLine($"N = {num} -> \"{SeriesNum(num)}\"");