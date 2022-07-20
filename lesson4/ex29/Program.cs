// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 int [] array = new int[8];
 int i = 0;
 while (i < 8) {
    array[i] = new Random().Next(-99, 99);
    i++;
 }


Console.WriteLine("[" + string.Join(", ", array) + "]");