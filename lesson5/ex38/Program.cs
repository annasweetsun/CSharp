// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Enter lenght of array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] array = new double[arrayLength];

void FillArrayDouble(double[] arr) {
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
    }
}

FillArrayDouble(array);
Console.WriteLine("[" + string.Join("; ", array) + "]");

double MinMax(double[] arr1) {
    double max = arr1[0];
    double min = arr1[0];
    for(int i = 0; i < arr1.Length; i++) {
        if (arr1[i] > max) max = arr1[i];
        if (arr1[i] < min) min = arr1[i];
    }
    double result = max - min;
    return(result);
}

Console.WriteLine(MinMax(array));