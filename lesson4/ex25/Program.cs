// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int p = a;
while (i < b)
{
    p = p * a;
    i++;
}
Console.Write(p);