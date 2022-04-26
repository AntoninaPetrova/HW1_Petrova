//Напишите программу, которая задаёт массив из некоторого количества элементов и 
//выводит их на экран с помощью функций. 
//(можно спрашивать количество вводимых элементов и вводить все значения с клавиатуры)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];
int index = 0;
    while (index < length)
   {
    System.Console.WriteLine("Введите значение элемента массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[index] = number;
    index++;
   }

void Print(int[]array)
{
    for (int i = 0; i < length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

Print(array);














//int Enter(int number)
//{
//    number = 0;
//    System.Console.WriteLine("Введите значение элемента массива: ");
//    number = Convert.ToInt32(Console.ReadLine());
//    return number;
//}
//System.Console.WriteLine(Enter(number));

