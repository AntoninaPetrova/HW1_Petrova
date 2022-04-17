int N = 8;
int i = 2;

while (i <= N)
{
    if (N % 2 == 0)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.WriteLine("2");
        N = N - 1;
    }
    i += 2;
}