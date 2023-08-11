// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
System.Console.WriteLine($"Было сгенерировано число {num}");
int digit1 = num / 10;
int digit2 = num % 10;
if (digit1 > digit2)
    System.Console.WriteLine($"Наибольшая цифра этого числа это {digit1}");
else if (digit1 == digit2)
    System.Console.WriteLine("Обе цифры этого числа равны");
else
    System.Console.WriteLine($"Наибольшая цифра этого числа это {digit2}");