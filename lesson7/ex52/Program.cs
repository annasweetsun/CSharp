// See https://aka.ms/new-console-template for more information
int m = 10;
int n = 10;
int[,] matrix = new int[m, n];

void FillMatrix(int[,] matr) {
    for(int i = 0; i < matr.GetLength(0); i++) {
        for(int j = 0; j < matr.GetLength(1); j++) {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

FillMatrix(matrix);

void PrintMatrix(int[,] mat) {
    for(int i = 0; i< mat.GetLength(0); i++) {
        for(int j = 0; j< mat.GetLength(1); j++) {
            Console.Write(mat[i, j] + "\t");
        }
    Console.WriteLine("");
    }
}

PrintMatrix(matrix);

double[] AverangeOfColumns(int[,] matr1) { 
    int[] sumOfColmn = new int[matr1.GetLength(1)];
    for(int i = 0; i < matr1.GetLength(1); i++) {
        for(int j = 0; j < matr1.GetLength(0); j++) {
            sumOfColmn[i] = (sumOfColmn[i] + matr1[j, i]); // / matr1.GetLength(0);
        }
    }
    double[] averange = new double[matr1.GetLength(1)];
    for(int k = 0; k < matr1.GetLength(1); k++) {
        averange[k] = Convert.ToDouble(sumOfColmn[k]) / matr1.GetLength(0);
    }
    return averange;
}

Console.WriteLine("[" + string.Join("; ", AverangeOfColumns(matrix)) + "]");