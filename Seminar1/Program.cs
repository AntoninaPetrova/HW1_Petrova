int number = new Random ().Next (10, 100);
int number2 = new Random ().Next (2, 5);
if (number%number2 == 0)
{
    System.Console.WriteLine($"Число {number} кратно числу {number2}");
}
else {
    System.Console.WriteLine($"Число {number} не кратно числу {number2}.");
    System.Console.WriteLine($"остаток {number%number2}");
}