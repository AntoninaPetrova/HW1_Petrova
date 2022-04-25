//Напишите (функцию) цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Power (int A, int B)
{
int power = 1;

for (int i = 0; i < B; i++)
{
    power = A * power;
}
return power;
}
System.Console.WriteLine(Power(3, 5)); 