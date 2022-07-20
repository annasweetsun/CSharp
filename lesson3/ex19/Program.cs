// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int a;
Console.Write("Enter number: ");
a = Convert.ToInt32(Console.ReadLine());

int a1 = a / 1000;
int a2 = a % 100;


if (a1 / 10 == a2 % 10 && a1 % 10 == a2 / 10) Console.Write("Yes");
else Console.Write("No");