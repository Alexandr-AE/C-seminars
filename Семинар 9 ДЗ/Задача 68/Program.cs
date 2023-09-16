// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}


int m = Input("Введите значение m: ");
int n = Input("Введите значение n: ");
System.Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Akkerman(m, n)}");