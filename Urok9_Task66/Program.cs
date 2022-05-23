// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// Рекурсия!
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void SumNums(int m, int n, int sum = 0)
{
    if (m > n)
        Console.Write(sum + " ");
    else
    {
        sum += m;
        m++;
        SumNums(m, n, sum);
    }
}
SumNums(m, n);