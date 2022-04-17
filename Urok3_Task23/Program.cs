//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

int N = 3;
int i = 1;
int cube = 0;
while (i <= N)
{
    cube = i*i*i;
Console.Write($"{cube}, ", cube);
i++;
}