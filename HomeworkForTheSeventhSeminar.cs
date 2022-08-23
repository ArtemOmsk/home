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
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 // и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
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
/*
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


void FindAverage(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum +=array[i,j];
        Console.Write(Math.Round(sum / array.GetLength(0), 2) + ";");
        sum = 0;
    }
}
int[,] array = CreatRandom2dArray(3, 4, 1,4);
Console.WriteLine("ваш массив ");
Show2Array(array);

Console.WriteLine("средние значения");
FindAverage(array);


*/
























