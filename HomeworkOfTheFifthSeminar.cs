

//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
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



int NumberOfEvenNumbers(int[] array)

{
    int h = 0;
    for(int  i = 0; i < array.Length; i++)
       if(array[i] % 2 == 0) h++;
       
       return h;
}
 int[] newarray = SumOfNumbers(5, 100, 999);
 ShowArray(newarray);
 Console.Write(NumberOfEvenNumbers(newarray));
*/

// Программа находящая сумму элементов, стоящих на нечётных позициях.

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
 

int TheSumOfOdd(int[] array)
{
    int h = 0;
    for(int i = 0; i < array.Length; i++)
    {
        
        if(i % 2 == 0);
        else h = h + array[i];
        
    }
    return h;
        
}
int[] newarray = SumOfNumbers(8, -999, 999);
 ShowArray(newarray);
 Console.Write(TheSumOfOdd(newarray));
 */
 
 // Массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
 
double[] arrayRealNumbers = new double[10];
for (int i = 0; i < arrayRealNumbers.Length; i++ )
{
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
}
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 1; i < arrayRealNumbers.Length; i++)
{
   if (maxNumber < arrayRealNumbers[i]) maxNumber = arrayRealNumbers[i];
   if (minNumber > arrayRealNumbers[i]) minNumber = arrayRealNumbers[i];
}
double decision = maxNumber - minNumber;
Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");