using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                System.Console.Write($"{matrix[i, j]}\t");
            System.Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] array = new int[n, m];
        int temp = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                array[i, j] = temp;
                temp += k;
            }
        return array;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        int[] result = new int[] { 0, 0 };
        if (rowPosition < matrix.GetLength(0) && columnPosition < matrix.GetLength(1))
            result[0] = matrix[rowPosition - 1, columnPosition - 1];
        return result;
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results[0] == 0)
            System.Console.WriteLine("There is no such index");
        else System.Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k, x, y;

        if (args.Length >= 5)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 4;
            m = 5;
            k = 3;
            x = 2;
            y = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}

// Решение от GB

// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//         for (int i=0; i<matrix.GetLength(0); i++)
//         {
//             for (int j=0; j<matrix.GetLength(1);j++)
//             {
//                 Console.Write($"{matrix[i,j]}"+"\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static int[,] CreateIncreasingMatrix(int n, int m, int k)
//     {
//         int[,] newMatrix = new int[n,m];
//         int currentValue = 1;
//         for (int i=0; i<n; i++)
//         {
//             for (int j=0; j<m; j++)
//             {
//                 newMatrix[i,j] = currentValue;
//                 currentValue += k;
//             }
//         }
//         return newMatrix;
//     }

//     public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
//     {  
//         int [] number={0,-1};
//         if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
//         {
//             number[1]=0;
//             number[0]=matrix[rowPosition-1,columnPosition-1];
//             return number;
//         }
//         return number;
//     }

//     public static void PrintCheckIfError (int[] results, int X, int Y)
//     {
//         if (results[1]==-1){Console.WriteLine("There is no such index");}
//         else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
//         }
//     }

//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k, x, y;

//         if (args.Length >= 5) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//            x = int.Parse(args[3]);
//            y = int.Parse(args[4]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//            x = 2;
//            y = 3;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
//     }
// }
