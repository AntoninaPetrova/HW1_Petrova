// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// 9 9 9
// 1 1 1
// 5 6 7
// -> вторая строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void MinSumRow(int[,] array)
{
int sum = 0;  
int minrow = Int32.MaxValue; 
int rownumber = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            sum +=array[i, j];
            
        }
        if (sum < minrow)
        {
        minrow = sum; 
        rownumber = i+1;       
        }

    }
System.Console.WriteLine($"Строка номер {rownumber} с наименьшей суммой элементов {minrow}");

}

int[,] array = new int[4, 5];
FillArray(array);
PrintArray(array);
MinSumRow(array);