// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Write("Enter count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count od columns: ");
int n = Convert.ToInt32(Console.ReadLine());
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
