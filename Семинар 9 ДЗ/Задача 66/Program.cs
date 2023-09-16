// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int SumNum(int n, int m)
{
    if (n == m)
        return m;
    return n + SumNum(n - 1, m);
}


int m = Input("Введите значение M: ");
int n = Input("Введите значение N: ");
System.Console.WriteLine($"M = {m}; N = {n} -> {SumNum(n, m)}");