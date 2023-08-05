// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 = -num;
// if (num < num1)
// {
//     num = num1;
//     num1 = -num;
// }
// while (num1 < num)
// {
//     Console.Write($"{num1}, ");
//     num1++;
// }
// Console.Write(num);




// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// while (num > 1000, num < 100)
// {
//     Console.Write("Введите ТРЕХзначное число: ");
//     int num1 = Convert.ToInt32(Console.ReadLine());
//     num = num1;
// }
// System.Console.WriteLine(num % 10);



// Напишите программу, которая принимает на вход целое число любой разрядности и на выходе 
// показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    System.Console.WriteLine("нет");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num % 10);
}