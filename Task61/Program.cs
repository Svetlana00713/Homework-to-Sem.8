//Задача 61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника.

Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] pascalTriangle = new int[n, n];
for(int i = 0; i < n; i++)
{
    int value = 1;
    for(int l = 0; l < n - i; l++)
    {
        Console.Write("   ");
    }
    for(int j = 0; j <= i; j++)
    {
        Console.Write("   {0:D}  ", value);
        value = value * (i - j) / (j + 1);
    }
    Console.WriteLine();
}


  
  