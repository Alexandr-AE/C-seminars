// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да


// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
//     Console.WriteLine("да");
// else
//     Console.WriteLine("нет");



// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}







// задача 1 необязательная

// на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.

// 1,45 -> 1,5
// 1 -> нет
// 567,123 -> 57,123

// Console.Write("Введите число: ");
// decimal numD = Convert.ToDecimal(Console.ReadLine());
// int numI = Convert.ToInt32(numD);
// int i = 10;
// int dotIndex = 10;
// if (numD == numI)
//     if (numD < 10)
//         System.Console.WriteLine("нет");
//     else
//     {
//         while (numI >= 10)
//         {
//             numI = numI / 10;
//             i = i * 10;
//             System.Console.WriteLine(numI);
//             System.Console.WriteLine($"i={i}");
//         }
//         i = i / 100;
//         System.Console.WriteLine(numI * i + Convert.ToInt32(numD) % i);
//     }
// else
// {
//     if (numI < 10)
//     {
//         dotIndex = dotIndex / 10;
//         i = i * 10;
//     }
//     while (numD != numI)
//     {
//         numD = numD * 10;
//         numI = Convert.ToInt32(numD);
//         dotIndex = dotIndex * 10;
//         System.Console.WriteLine($"numD = {numD}");
//         System.Console.WriteLine($"numI = {numI}");
//         System.Console.WriteLine($"dotIndex = {dotIndex}");
//     }
//     dotIndex = dotIndex / 10;
//     while (numI >= 10)
//     {
//         numI = numI / 10;
//         i = i * 10;
//         System.Console.WriteLine(numI);
//         System.Console.WriteLine($"i={i}");
//     };
//     i = i / 100;
//     System.Console.WriteLine();
//     System.Console.WriteLine($"numD = {numD}");
//     System.Console.WriteLine($"numI = {numI}");
//     System.Console.WriteLine($"dotIndex = {dotIndex}");
//     System.Console.WriteLine($"i={i}");
//     System.Console.WriteLine(Convert.ToDouble((numI * i + Convert.ToInt32(numD) % i)) / dotIndex);
// }

