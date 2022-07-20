// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//Console.WriteLine("Имя: " + name + " | Фамилия: " + surname + " | Возраст: " +age.ToString());

double xa = 0, ya = 0, za = 0, xb = 0, yb = 0, zb = 0;

Console.Write("Enter coordinats of A: ");
xa = Convert.ToDouble(Console.ReadLine());
ya = Convert.ToDouble(Console.ReadLine());
za = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter coordinats of B: ");
xb = Convert.ToDouble(Console.ReadLine());
yb = Convert.ToDouble(Console.ReadLine());
zb = Convert.ToDouble(Console.ReadLine());


double gip = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
gip = Math.Round(gip, 2);
Console.WriteLine("расстояние: {0}", gip);
