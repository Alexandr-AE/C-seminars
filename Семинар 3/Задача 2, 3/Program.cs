// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Write("Введите координату x точки A: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки A: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
int yb = Convert.ToInt32(Console.ReadLine());
double Dist(int xa, int ya, int xb, int yb)
{
    double Distance = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb));
    return Distance;
}
// double Distance = Dist(xa, ya, xb, yb);
System.Console.Write($"Расстояние между точками A({xa},{xb}) и B({ya},{yb}) равно {Dist(xa, ya, xb, yb)}");





// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// string Square(int a)
// {
//     string result = $"{a} -> ";
//     for (int i = 1; i <= a; i++)
//     {
//         if (i < a)
//             result = result + $"{i * i}, ";
//         else result = result + $"{i * i}.";
//     }
//     return result;
// }

// string SquareTable = Square(a);
// Console.WriteLine(SquareTable);
