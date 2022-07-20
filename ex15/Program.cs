// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter the number of day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 7) Console.WriteLine("There are seven days of the week.");
else if (a < 1) Console.WriteLine("There are seven days of the week.");
// так и не поняла, почему не работает составное условие и разделила на два, но
else {
    if (a > 5) Console.WriteLine("Day off. You can relax.");
    else {
        Console.WriteLine("It is not day off. Go to the work.");
    }
    
}