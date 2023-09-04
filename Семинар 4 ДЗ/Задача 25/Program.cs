// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Degree(int a, int b)
{
    int product = 1;
    for (int i = 0; i < b; i++)
    {
        product *= a;
    }
    System.Console.WriteLine($"Число {a} в степени {b} равно {product}");
}
int Input(string mess)
{
    System.Console.Write(mess);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
// System.Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());
int a = Input("Введите число A: ");
int b = Input("Введите число B: ");
Degree(a, b);