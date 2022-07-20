// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Write("Enter three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

//a = a % 100 / 10;
Console.Write(a % 100 / 10);