// необязательная задача SORT 
// Написать программу сортировки массива от большего к меньшему. 
// Массив задается размерностью N с клавиатуры, далее заполняется 
// случайными целыми числами от -100 до 100, выводится на экран. 
// Сортируется, и затем опять выводится на экран.
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(-100, 101);
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
void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPos = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[maxPos]) maxPos = j;
        }
        int temporary = arr[i];
        arr[i] = arr[maxPos];
        arr[maxPos] = temporary;
    }
}

System.Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SortArray(array);
PrintArray(array);