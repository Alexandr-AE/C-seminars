// Задача 2 HARD по желанию Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4

Console.Write("Введите число: ");
decimal numD = Convert.ToDecimal(Console.ReadLine());
long numI = Convert.ToInt32(numD);
int index = 0;
if (numD < 1)
{
    index = 1;
    while (numD != numI)
    {
        numD = numD * 10;
        numI = Convert.ToInt32(numD);
        index++;
    }
}
else
{
    while (numD != numI)
    {
        numI = System.Convert.ToInt32(numD = numD * 10);
    }
    while (numI > 0)
    {
        numI = numI / 10;
        index++;
    }
}
System.Console.WriteLine(index);