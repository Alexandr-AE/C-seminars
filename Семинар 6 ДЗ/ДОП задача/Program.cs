// Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

// Пример:

// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи]

int[] NegFibArray(int k)
{
    int[] array = new int[k * 2 + 1];
    array[k] = 0;
    array[k +1] = 1;
    array[k -1] = 1;
    for (int i = 2; i <= k; i++)
    {
        array[k+i] = array[k+i-1] + array[k+i-2];
        array[k-i] = array[k-i+2] - array[k-i+1];
    }
    return array;
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

System.Console.Write("Введите количество символов последовательности после нуля: ");
int k = Convert.ToInt32(Console.ReadLine());
PrintArray(NegFibArray(k));