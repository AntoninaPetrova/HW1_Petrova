void FillArrayRandom(int [,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

int m, n;
Console.WriteLine("Введите количество строк (m):");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArrayRandom(array, -9, 10);
PrintArray(array);

//int SummDiagonal (int[,] array)
//{
//    int summa = 0;
//    int minLength = Math.Min(array.GetLength(0), array.GetLength(1));
//        for (int j = 0; j < minLength; j++)
//        {
//            summa = array[j, j] + summa;
//        }
//    return summa;
//}