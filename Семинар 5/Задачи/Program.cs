// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 
// 29, сумма отрицательных равна -20.

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

// void FindSums(int[] array)
// {
//     int sumP = 0;
//     int sumN = 0;
//     foreach (int item in array)
//         if  (item > 0)
//             sumP += item;
//         else
//             sumN += item;
//     System.Console.WriteLine($"Сумма отрицательных элементов равна {sumN}");
//     System.Console.WriteLine($"Сумма положительных элементов равна {sumP}");
// }

// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// FindSums(array);


// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9, 10);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }
// void ChangeArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = array[i] * (-1);
// }

// int[] array = new int[4];
// FillArray(array);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);



// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int[] array)
// {System.Console.Write(" [ ");
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.Write(" ] ");
// }

// void FindNum(int[] array, int f)
// {
//     System.Console.Write($" { f }");
//     bool result = false;
//     foreach (int item in array)
//         if  (item==f){ 
//             result=true;
//             break;
//         }
//     if(!result)System.Console.Write($" -> нет");
//     else System.Console.Write($" -> да");
// }

// int[] array = new int[12];
// FillArray(array);
// PrintArray(array);
// FindNum(array ,num);






// Задача 35: Задайте одномерный массив из 15 случайных чисел в 
// диапазоне от -100 до 100. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 15 элементов. 
// В своём решении сделайте для 15
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(-100,100);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         System.Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void SumArray(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] >= 10 && array[i] <= 99)
//         count = count + 1;
//     Console.WriteLine($"Количество элементов {count}");
// }

// int[] array = new int[15];

// FillArray(array);
// PrintArray(array);
// SumArray(array);






// Timur Islamgulov 11:16
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и
//  т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21