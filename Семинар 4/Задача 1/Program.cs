// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbers(int upper)
// {
// int res = 0;
// for (int i = 1; i <= upper; i++)
// res += i; //res = res + i
// return res;
// }

// System.Console.WriteLine("Введите натуральное число ");
// int num = Convert.ToInt32 (Console.ReadLine());
// System.Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {SumNumbers(num)}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int AmountNumbers(int num)
{
    int j = 0;
    if (num == 0)
        j = 1;
    for (int i = 0; num != 0; i++)
    {
        num = num / 10;
        j++;
    }
    return j;
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"В вашем числе {AmountNumbers(a)} цифр(а/ы)");