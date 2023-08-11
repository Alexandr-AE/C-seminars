// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98




// int num = new Random().Next(100, 1000);
// System.Console.WriteLine($"Было сгенерировано число {num}");

// int digit1 = num / 100;
// int digit3 = num % 10;

// System.Console.WriteLine($"{digit1}{digit3}");


// Напишите программу которая на вход принимает от пользователя 
// число любой разрядности и удаляет вторую цифру слева 


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num / 100 == 0)
    System.Console.WriteLine(num / 10);
else
{
    while (num > 0)
    {
        num = num / 10;
        digit = num % 10;
        
    }
    System.Console.WriteLine(num % 10);
}


// int digit1 = num / 100;
// int digit3 = num % 10;

// System.Console.WriteLine($"{digit1}{digit3}");
