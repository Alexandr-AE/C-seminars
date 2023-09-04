// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Sum(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a = a / 10;
    }
    System.Console.WriteLine($"Сумма цифр равна {sum}");
}

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Sum(num);