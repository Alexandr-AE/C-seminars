// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Degree(int a, int b)
{
    int product = 1;
    for (int i = 0; i < b; i++)
    {
        product = product * a;
    }
    System.Console.WriteLine($"Число {a} в степени {b} равно {product}");
}

System.Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Degree(a, b);