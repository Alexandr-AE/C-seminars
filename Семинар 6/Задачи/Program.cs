// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void ReverseArray(int[] array)
// {
//     // int buf;
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         // buf = array[i];
//         // array[i] = array[array.Length - 1 - i];
//         // array[array.Length - 1 - i] = buf;
//         (array[i], array[array.Length - 1 - i]) = (array[array.Length - 1 - i], array[i] );
//     }
// }

// System.Console.WriteLine("Введите количество элементов массива");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[len];
// FillArray(array);
// PrintArray(array);
// ReverseArray(array);
// PrintArray(array);






// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

// bool existtrialange(int a, int b, int c)
// {
//     bool result = false;
//     if ((a + b) > c && (a + c) > b && (b + c) > a)
//         result = true;
//     return result;
// }
// int Input(string mess)
// {
//     System.Console.Write(mess);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }
// int a = Input("Введите длину первой стороны: ");
// int b = Input("Введите длину второй стороны: ");
// int c = Input("Введите длину третьей стороны: ");
// System.Console.WriteLine(existtrialange(a, b, c));






// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int n = a, i = 0;
// string Binare(int num)
// {
//     string result = "";
//     while (num > 0)
//     {
//         result = (num % 2) + result;
//         num /= 2;
//     }
//     return result;
// }

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Binare(num));






// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int[] FibArray(int N)
// {
//     int[] array = new int[N];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }
// void PrintArray(int[] arr)
// {
//     System.Console.Write("[ ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1)
//             System.Console.Write($"{arr[i]}, ");
//         else System.Console.Write($"{arr[i]}");
//     }
//     System.Console.Write(" ]");
// }

// System.Console.Write("Введите количество первых N чисел Фибоначчи: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] array = FibArray(N);
// PrintArray(array);



// 5.Задайте число.Составьте список чисел Фибоначчи,
// в том числе для отрицательных индексов.

//     *Пример:*

//     -для k = 8 список будет выглядеть так:
//      [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21][Негафибоначчи]
//        0   1   2   3   4  5   6  7  8  9 10 11 12 13 14  15  16 

int[] NegFibArray(int k)
{
    int[] array = new int[k * 2 + 1];
    array[k] = 0; //начало последовательности
    array[k +1] = 1;
    array[k -1] = 1;
    for (int i = 2; i <= k; i++)
    {
        array[k+i] = array[k+i-1] + array[k+i-2];
        array[k-i] = array[k-i+2] - array[k-i+1];
    }
    return array;
}
void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            System.Console.Write($"{arr[i]}, ");
        else System.Console.Write($"{arr[i]}");
    }
    System.Console.Write("]");
}

System.Console.Write("Введите 'k' негаФибоначчи: ");
int k = Convert.ToInt32(Console.ReadLine());
PrintArray(NegFibArray(k));