//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3, 7, 22, 2, 78] -> 76


void Random(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-100, 100);
    }
}

void Print(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}

double[] mas = new double[10];
Random(mas);
Print(mas);

double max = 0;
double min = 0;
min = mas[0];
max = mas[0];
for (int i = 1; i < mas.Length; i++)
{
       if (mas[i] < min)
            min = mas[i];
       if (mas[i] > max)
            max = mas[i];
}
double diff = max - min;
Console.WriteLine();
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);