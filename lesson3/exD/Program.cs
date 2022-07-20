// Будем называть числа круглыми, если они содержат в своей записи только цифры 0 и 5. 
// Составим последовательность неотрицательных целых круглых чисел в порядке возрастания: 0, 5, 50, 55, 500, 505 и так далее.
// Написать программу, которая находит K-е по порядку в этой последовательности круглое число.


int i = 0;

Console.Write("Enter k: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] array = new int[k];


while (i < k) 
{
    string p = Convert.ToString(i, 2); // в двоичный код
    int r = Convert.ToInt32(p); // обратно в число
    array[i] = r * 5;
    i++;
}

//string mass = string.Join(" ", array);
//Console.WriteLine(mass);

Console.WriteLine(array[k-1]);
