// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int n;
Console.Write("Enter number: ");
n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n) {
    Console.Write(i*i*i);
    Console.Write(" ");
    i++;

 
}