// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Вывод:
// a[0, 0, 0] = 2
// a[0, 0, 1] = 4

void FillArray(int[,,] array)
{
    int n = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = n;
                n += 1;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                System.Console.WriteLine($"a[{i}, {j}, {k}] = {array[i, j, k],2}");
            }
        }
    }
    System.Console.WriteLine();
}

int[,,] array = new int[3, 2, 3];

if (array.GetLength(0) * array.GetLength(1) * array.GetLength(2) > 90)
{
    System.Console.Write("Матрицу нельзя заполнить неповторяющимися двузначными числами");
}
else
{
    FillArray(array);
    PrintArray(array);
}