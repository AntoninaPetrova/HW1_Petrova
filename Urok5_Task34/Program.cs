// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(100, 1000);
    }
}

void Print(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        System.Console.Write(mas[i] + " ");
    }
    System.Console.WriteLine();
}

int[] mas = new int[10];
Random(mas);
Print(mas);

int number = 0;
for (int i = 0; i < mas.Length; i++)
{
   if (mas[i]%2 == 0) 
   {
       number = number +1;
   }
}
System.Console.WriteLine(number);   
    