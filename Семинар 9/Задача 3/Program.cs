
int Fibonaci(int n) 
{ 
    if (n == 1 || n == 2) 
        return n - 1; 
    return Fibonaci(n - 1) + Fibonaci(n - 2); 
} 
 
System.Console.WriteLine("Введите натуральное число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(Fibonaci(n));


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) 
// A = 2; B = 3 -> 8 
 
// int Sqare(int a, int b) 
// { 
//     if (b == 1) 
//         return a; 
//     return a * Sqare(a, b-1); 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int a = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите степень "); 
// int b = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(Sqare(a, b));

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 
// 45 -> 9 
 
// int SumDigits(int n) 
// { 
//     if (n == 0) 
//         return 0; 
//     return n % 10 + SumDigits(n / 10); 
// } 
 
// System.Console.WriteLine("Введите натуральное число "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine($"Сумма цифр числа равна: {SumDigits(n)}");