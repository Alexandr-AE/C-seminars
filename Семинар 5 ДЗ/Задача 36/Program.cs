// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");
}

int Input(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(int[] array, int x, int y)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(x, y + 1);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.WriteLine("]");
}

int size = Input("Введите длину массива: ");
int x = Input("Введите минимальное значение случайных чисел: ");
int y = Input("Введите максимальное значение случайных чисел: ");
int[] array = new int[size];
FillArray(array, x, y);
PrintArray(array);
SumOddElements(array);