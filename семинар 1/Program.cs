// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
System.Console.WriteLine();
//Console.WriteLine(square);
Console.WriteLine($"Квадрат введенного числа равен {square}");

if (num > 0)
{
    Console.WriteLine("Это положительное число");
}
else if (num == 0)
    Console.WriteLine("Это ноль");
else
    Console.WriteLine("Число отрицательное");

int i = 1;
while (i <= 10)
{
    Console.Write($"{i} ");
    i = i + 1;
    // i++;
}
Console.WriteLine();

