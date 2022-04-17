int number = new Random().Next(100, 999);
System.Console.WriteLine(number);

int b = number / 100 % 10;
System.Console.Write(b);
int a = number % 10;
System.Console.Write(a);