// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
int index = 0;
    while (index < M)
   {
    System.Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[index] = number;
    index++;
   }

/*void Print(int[]array)
{
    for (int i = 0; i < M; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}*/

int Positive(int[]array)
{
    int number = 0;
    for (int i = 0; i < M; i++)
    {
        if (array[i] > 0)
            number += 1;
    }
    return number;
}

System.Console.WriteLine("Количество положительных чисел: ");
System.Console.WriteLine(Positive(array));
