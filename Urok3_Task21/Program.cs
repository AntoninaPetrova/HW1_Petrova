//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

double x1 = 3;
double y1 = 6;
double z1 = 8;
double x2 = 2;
double y2 = 1;
double z2 = -7;
double d = (x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2);
d = Math.Sqrt(d); 
Console.WriteLine("{0:f}", d);