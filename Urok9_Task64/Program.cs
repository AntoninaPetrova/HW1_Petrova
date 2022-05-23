//  Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Рекурсия!

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void GetSum(int n, int sum = 0)
{
    if (n < 1)
        Console.Write(sum + " ");
    else
    {
        sum = sum + n % 10;
        GetSum(n = n / 10, sum);
    }
}
GetSum(n);