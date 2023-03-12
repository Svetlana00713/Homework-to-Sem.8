//Задача 62. Напишите программу, которая заполнит спирально 
//массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.Write("Введите размер матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] MatrixSpiral = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while(temp <= n * n)
{
    MatrixSpiral[i, j] = temp;
    temp++;
    if(i <= j + 1 && i + j < n - 1) j++;
    else if(i < j && i + j >= n - 1) i++;
    else if(i >= j && i + j > n - 1) j--;
    else i--;
}
PrintMatrix(MatrixSpiral);
int[,] PrintMatrix(int[,] MatrixSpiral)
{
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < n; j++)
        {
            if(MatrixSpiral[i,j] / 10 <= 0)
            {
            Console.Write($"{0}{MatrixSpiral[i,j]} ");
            }
            else Console.Write($"{MatrixSpiral[i,j]} ");
        }
    Console.WriteLine();
    }
return MatrixSpiral;
}


