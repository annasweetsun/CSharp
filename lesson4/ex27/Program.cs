//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter number: ");
int a = Convert.ToInt32(Console.ReadLine());
int e = a;
int sum = 0;
while (e > 0)
{
    e = a % 10;
    sum = sum + e;
    a = a / 10;
}

Console.Write(sum);
