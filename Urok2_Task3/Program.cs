int number = 22;
if (number <=99)
Console.WriteLine("третьей цифры нет");
else
{
while (number >= 1000)
number = number /10;
Console.WriteLine(number % 10);
}