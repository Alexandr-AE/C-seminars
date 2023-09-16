
// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> "1, 2, 3, 4, 5" 
// N = 6 -> "1, 2, 3, 4, 5, 6" 
 
 
 
// string PrintNumbers(int n) 
// { 
//     if (n == 0) 
//         return ""; 
//     return PrintNumbers(n - 1) + $"{n} "; 
 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(n));

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 
 
 
string PrintNumbers(int m, int n) 
{ 
    if (n < m) 
        return ""; 
    return PrintNumbers(m, n - 1) + $"{n} "; 
} 
 
System.Console.WriteLine("Введите нижнюю границу M"); 
int min = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int max = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(PrintNumbers(min, max));