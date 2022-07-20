
// улитка через цикл
int h, a, b;
h = 10; // расстояние S
a = 3; // скорость в день Vd
b = 2; // скорость за ночь Vn
// а - b скорость за сутки
int h1 = 0;
int day1 = 0;
while (h1 < (h - a) )
{
    h1 = h1 + a - b;
    day1++;
}

Console.Write(day1 + 1);

