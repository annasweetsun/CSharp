// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
int m = 10;
int n = 10;
double[,] matrix = new double[m, n];

void FillMatrix(double[,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            matr[i, j] = Convert.ToDouble(new Random().Next(-999, 1000)/10.0);
        }
    }
}

FillMatrix(matrix);

void PrintMatrix(double[,] mat) {
    for(int i = 0; i< mat.GetLength(0); i++) {
        for(int j = 0; j< mat.GetLength(1); j++) {
            Console.Write(mat[i, j] + "\t");
        }
    Console.WriteLine("");
    }
}

PrintMatrix(matrix);

Console.Write("Enter row: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column: ");
int b = Convert.ToInt32(Console.ReadLine());

void SearchOfelements(int a, int b, double[,] matr1) {
    if (a < matr1.GetLength(0) && b < matr1.GetLength(1)) Console.Write(matr1[a, b]);
    else Console.Write("No such position");
}
SearchOfelements(a, b, matrix);