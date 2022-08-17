/*
int[] SumOfNumbers(int size,int minv, int maxv)
 {
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minv, maxv + 1);
    return newArray;
 }

void ShowArray(int[] array)

 {
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
 }


int[,] CCreatRandom2dArray(int rows, int columns, int minv, int maxv)
{
    int[,] newArray = new int [rows, columns];

    for( int i = 0; i < rows; i++);
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

//Задайте двумерный массив размера m на n, каждый элемент в массиве 
//находится по формуле: Aij = i+j. Выведите полученный массив на экран.
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
 //Задайте двумерный массив. Найдите сумму элементов, 
 //находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

/*
int[] SumOfNumbers(int size,int minv, int maxv)
 {
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minv, maxv + 1);
    return newArray;
 }

int[,] CCreatRandom2dArray(int n, int m, int min, int max)
{
    int[,] newArray = new int [n, m];

    for( int i = 0; i < n; i++)
    {
        for( int j = 0; j < m; j++)
        {
            newArray[i,j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}
int[,] CCreat(int[,]array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            if(i == j && i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;

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

Console.Write(" введите число строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите число столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CCreatRandom2dArray(n, m, min, max);
int[,] ccreat = CCreat(array);
Show2Array(ccreat)
*/