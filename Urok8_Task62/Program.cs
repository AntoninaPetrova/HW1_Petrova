// Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int s = 1;
int[,] array = new int[m, n];

for (int y = 0; y < n; y++)
{
    array[0, y] = s;
    s++;
}
for (int x = 1; x < m; x++)
{
    array[x, n - 1] = s;
    s++;
}

for (int y = n - 2; y >= 0; y--)
{
    array[m - 1, y] = s;
    s++;
}
for (int x = m - 2; x > 0; x--)
{
    array[x, 0] = s;
    s++;
}

int c = 1;
int d = 1;

while (s < m * n)
{
    while (array[c, d + 1] == 0)
    {
        array[c, d] = s;
        s++;
        d++;
    }

    while (array[c + 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c++;
    }

    while (array[c, d - 1] == 0)
    {
        array[c, d] = s;
        s++;
        d--;
    }

    while (array[c - 1, d] == 0)
    {
        array[c, d] = s;
        s++;
        c--;
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] == 0)
        {
            array[x, y] = s;
        }
    }
}

for (int x = 0; x < m; x++)
{
    for (int y = 0; y < n; y++)
    {
        if (array[x, y] < 10)
        {
            System.Console.Write(array[x, y] + "  ");
        }
        else
        {
            System.Console.Write(array[x, y] + " ");
        }
    }
    System.Console.WriteLine();
}