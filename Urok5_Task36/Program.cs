//Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


void Random(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(-100, 100);
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

int sum = 0;
for (int i = 0; i < mas.Length; i++)
{
   if (i%2 != 0) 
   {
       sum = sum + mas[i];
   }
}
System.Console.WriteLine(sum);   
    