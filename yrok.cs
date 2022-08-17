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
*/
//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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


int[,] ctrArray(int[,] array)
{
    int imin = 0, jmin = 0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for(int i = 0; i < array.GetLength(0); i++)
    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < array[imin, jmin])
            {
                jmin = i;
                jmin = j;
            }
        }

    for(int i = 0, m = 0; i < array.GetLength(0); i++, m++)
    {
            if(i == imin) i++;

         for(int j = 0, n = 0; j < array.GetLength(1); j++, n++)
         {
            if(j == imin) j++;

            newArray[m,n] = array[i, j];

         }
    }
    return newArray;
}

Console.Write(" введите число строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите число столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreatRandom2dArray(n, m, min, max);
Show2Array(array);
Show2Array(ctrArray(array));
*/

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
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



int[,] ReplaceRowsColumns(int[,] array)
{
   int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];

   for (int i = 0; i < array.GetLength(0); i++)
   {
    
    for(int j = 0; j < array.GetLength(0); j++)
        newArray[j, i] = array[i, j];
    
   }
   return newArray;
}

Console.Write(" введите число строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите число столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreatRandom2dArray(n, m, min, max);
Show2Array(array);
if(array.GetLength(0) != array.GetLength(1))
Console.WriteLine("нe такой");
else Show2Array(ReplaceRowsColumns(array));
*/
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

int[,] ChangeRows( int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp = array[0,i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
    return array;
}

Console.Write(" введите число строк ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите число столбцов ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = CreatRandom2dArray(n, m, min, max);
Show2Array(array);
Show2Array(ChangeRows(array));
*/