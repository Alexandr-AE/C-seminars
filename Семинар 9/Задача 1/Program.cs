// // Посчитать сумму всех чисел от 1 до N, где N вводит пользователь.

// int SummaCycle(int n)
// {
//     // int sum = 0;
//     // while (true)
//     //     {
//     //         if (n == 0)
//     //             break;
//     //         sum = sum + n;
//     //         n = n - 1;
//     //     }
//     // return sum;
//     int sum = 0;
//     while (n > 0)
//     {
//         sum = sum + n;
//         n = n - 1;
//     }
//     return sum;
// }

// int SummaRec(int n)
// {
//     if (n == 0)
//         return 0;
//     return n + SummaRec(n - 1);
// }




// System.Console.WriteLine("Введите натуральное число ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SummaCycle(n));


// Посчитать сумму всех чисел от 1 до N, где N вводит пользователь.

int SummaCycle(int n)
{
    int sum = 0;
    while (true)
        {
            if (n == 0)
                break;
            sum = sum + n;
            n = n - 1;
        }
    return sum;
}

int SummaRec(int n)
{
    if (n  == 0)
        return 0;
    return n + SummaRec(n - 1);
}

//SummaRec(4)
// 4 + (3 + (2 + ( 1 + 0)))
// 4 + ( 3 + 3)
// 10


System.Console.WriteLine("Введите натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SummaCycle(n));
System.Console.WriteLine(SummaRec(n));