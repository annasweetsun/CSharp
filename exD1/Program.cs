﻿
//Улитка ползёт по вертикальному шесту высотой h метров, поднимаясь за день на a метров, 
// а за ночь спускаясь на b метров. На какой день улитка доползёт до вершины шеста?
int h, a, b;
h = 10; // расстояние S
a = 3; // скорость в день Vd
b = 2; // скорость за ночь Vn
// а - b скорость за сутки
int day; // дни 
// в последние сутки у нас В не учитывается, ибо улитка поднялась на А, достигла цели и нам уже не надо учитывать ночной спуск.
// что бы получить время нужно поделить расстояние на скорость 
// нам надо посчитать сколько раз повторить операцию А-В, что б осталось число меньше или равно А. И прибавить 1 (последний день)
// h - a - расстояние, которое нам надо пройти со скоростью А-В. Т.е. (h-a)/(a-b) +1 
// проблема при делении округляется в сторону меньшего. Потенциальное решение - прибавлять к числу что-то что б делилось как большее
// (10-3)/1? понять как делится на си шарпе
// int test = 5/3;
day = (h - b - 1) / (a - b) + 1;
Console.Write(day);
//
int h1 = 0;
int day1 = 0;
while (h1 < (h - a) )
{
    h1 = h1 + a - b;
    day1++;
}

Console.Write(day1 + 1);
