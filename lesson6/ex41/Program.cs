// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
Console.Write("Enter count of numbers (M): ");
int M = Convert.ToInt32(Console.ReadLine());

int[] arrayM = new int[M];
for(int i = 0; i < M; i++) {
    Console.Write("Enter " + (i+1) + " number of array: ");
    arrayM[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("[" + string.Join(", ", arrayM) + "]");
Console.WriteLine();

int CountOfPositiveNumber(int[] arr) {
    int count = 0;
    for(int j = 0; j < arr.Length; j++) {
        if(arr[j] > 0) count++;
    }
    return count;
}

Console.WriteLine("Count of even numbers: " + CountOfPositiveNumber(arrayM));
