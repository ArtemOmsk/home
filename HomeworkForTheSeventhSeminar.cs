//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreatRandom2dArray(int rows, int columns, int minv, int maxv)
{
    double[,] newArray = new double [rows, columns];

    for( int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minv, maxv + 1) + Math.Round (new Random().NextDouble(), 1);
        }
    }
    return newArray;

}

void Show2Array(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " " );
        }
        Console.WriteLine();
    }
}
Console.Write(" введите число строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите число столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] array = CreatRandom2dArray(n, m, min, max);
Show2Array(array);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 // и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreatRandom2dArray(int rows, int columns, int minv, int maxv)
{
    int[,] newArray = new int [rows, columns];

    for( int i = 0; i < rows; i++)
    {
        for( int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minv, maxv + 1);
           
        }
    }
    return newArray;

}

void Show2Array(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " " );
        }
        Console.WriteLine();
    }
}
 
Console.Write(" введите i ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("  введите j ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = CreatRandom2dArray(4, 4, 0, 9);
Show2Array(array);
if (m >= array.GetLength(0) || n >= array.GetLength(1))
     Console.WriteLine($"ячейка с индексов {m}, {n} не существует ");
     else
   Console.WriteLine($" значение ячейки с индексов{m}, {n} в массиве равно {array[m, n]} ");
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");
double [,]arr=new double [n, m];
double []sum=new double [m];
Random ran = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = ran.Next(0, 10);

        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.Write((sum[i] / n)  + " ");
}
