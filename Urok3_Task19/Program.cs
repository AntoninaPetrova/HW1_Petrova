﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

int number = 52325;
int a1 = number % 10;
int a5 = number / 10000 % 10;
int a2 = number / 10 % 10;
int a4 = number / 1000 % 10;
if (a1 == a5 && a2 == a4)
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Число НЕ является палиндромом");