// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// 1. вводим длину массива, 2. пишем функцию, заполняющую массив этой длинны 
// 3. проверяем числа массива на четность, если четное прибавляем к каунт +1

Console.Write("Enter lenght of array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

void FillArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(100, 999);
    }
}

FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int CountOfEven(int[] arr1) {
    int count = 0;
    for(int j = 0; j < arr1.Length; j++) {
        if (arr1[j] % 2 == 0) {
            count++;
        }
    }
    return(count);
}

int countEven = CountOfEven(array);
Console.WriteLine(countEven);