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

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        System.Console.WriteLine("The averages in columns are: ");
        foreach (double item in list)
            System.Console.Write($"{item:F2}\t");
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        double[] averages = new double[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                averages[j] = averages[j] + matrix[i, j];
            }
            averages[j] = averages[j] / matrix.GetLength(0);
        }
        return averages;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}

// Вариант решения от GB
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

//     static void PrintListAvr (double [] list)
//     {
//         Console.WriteLine("The averages in columns are: ");
//         foreach (double el in list)
//         {
//             Console.Write($"{el:f2}"+"\t");

//         }
//         Console.WriteLine();
//     }

//     static double [] FindAverageInColumns (int [,] matrix)
//     { 
//         double runningSum=0;
//         double [] columns = new double [matrix.GetLength(1)];
//         for (int j=0; j<matrix.GetLength(1);j++)
//         {
//             runningSum=0;
//             for (int i=0; i<matrix.GetLength(0);i++)
//             {
//                 runningSum=runningSum+matrix[i,j];
//             }
//             columns[j]=runningSum/matrix.GetLength(0);
//         }
//         return columns;
//     }


//     // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int n, m, k;

//         if (args.Length >= 3) {
//            n = int.Parse(args[0]);
//            m = int.Parse(args[1]);
//            k = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            n = 3;
//            m = 4;
//            k = 2;
//         }

//         // Не удаляйте строки ниже
//         int[,] result = CreateIncreasingMatrix(n, m, k);
//         PrintArray(result);
//         PrintListAvr(FindAverageInColumns(result));
//     }
// }
