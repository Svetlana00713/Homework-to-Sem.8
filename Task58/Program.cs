//Задача 58: Задайте две матрицы. Напишите программу, которая 
//будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Write("Введите кол-во строк первой матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк второй матрицы: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = FillMatrix(n,m);
int[,] matrixB = FillMatrix(k,l);
PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
int[,] matrixC = new int[n,l];
ProduktMatrix(n, m, k, l);
PrintMatrix(matrixC);

int[,] ProduktMatrix(int n, int m, int k, int l)
{
    if(m-k != 0)
    {
    Console.Write($"Произведение матриц не может быть найдено");
    Console.WriteLine();
    return matrixC;
    }
    for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < l; j++)
            {
                matrixC[i,j] = 0;
                for(int g = 0; g < k; g++)
                {
                    matrixC[i,j]+= (matrixA[i,g] * matrixB[g,j]);
                }
            }
        }
    return matrixC;    
}

int[,] FillMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
    Console.WriteLine();
    }
}
    



