//int [] array = new int [10, 99];
//new Random ().Next
int x = new Random ().Next (10, 100);
Console.Write(x + ",");
if (x % 10 > x / 10) System.Console.WriteLine(x % 10);
else System.Console.WriteLine( x / 10); 