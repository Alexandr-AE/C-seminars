// Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

string Range(int a)
{
    string result = "Нет такой четверти";
    if (a == 1)
        result = "x > 0, y > 0";
    else if (a == 2)
        result = "x < 0, y > 0";
    else if (a == 3)
        result = "x < 0, y < 0";
    else if (a == 4)
        result = "x > 0, y < 0";
    return result;
}
Console.Write("Введите номер четверти координатной плоскости: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Range(a));

// if (a <= 0 || a > 4)
//     System.Console.WriteLine("Нет такой четверти");
// else if (a == 1)
//     System.Console.WriteLine("x > 0, y > 0");
// else if (a == 2)
//     System.Console.WriteLine("x < 0, y > 0");
// else if (a == 3)
//     System.Console.WriteLine("x < 0, y < 0");
// else if (a == 4)
//     System.Console.WriteLine("x > 0, y < 0");