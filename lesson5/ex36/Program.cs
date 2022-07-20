//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//Console.Write("Enter lenght of array: ");
//int arrayLength = Convert.ToInt32(Console.ReadLine());
int arrayLength = 10;
int[] array = new int[arrayLength];

void FillArray(int[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 999);
    }
}

FillArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int SummEvenIndex(int[] arr1) {
    int sum1 = 0;
    for(int j = 0; j < arr1.Length; j++) {
        if (j % 2 == 0) {
            sum1 = sum1 + arr1[j];
        }
    }
    return(sum1);
}

int sum = SummEvenIndex(array);
Console.WriteLine(sum);