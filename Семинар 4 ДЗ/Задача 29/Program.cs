// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// случайных целых чисел от 1 до 50 и выводит их на экран.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(1, 51);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            System.Console.Write($"{arr[i]}, ");
        }
        else System.Console.Write($"{arr[i]}");
    }
}
int[] array = new int[8];
// System.Console.Write("Введите длину массива: ");
// int LengthArray = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[LengthArray];
FillArray(array);
PrintArray(array);