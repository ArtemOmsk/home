
// цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
double WeRaiseToADegree(double numA, double numB)
{ 
    double WeRaiseToADegree = Math.Pow(numA, numB);
    
    Console.WriteLine($"{numA} ^ {numB} = {WeRaiseToADegree}");
    
    return WeRaiseToADegree;   
}
Console.Write("введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double weRaiseToADegree = WeRaiseToADegree(numberA, numberB);
*/
 //Программа которая принимает на вход число и выдаёт сумму цифр в числе.
 /*
int SumOfNumbers(int num)
{
  int result = 0;
 while(num > 0)
 {
    result = result + num % 10;
    num = num / 10;
 }
 return result;
}
 
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int nam = SumOfNumbers(number);
Console.WriteLine(nam);
*/
//Программа которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] SumOfNumbers(int size)
 {
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next();
    return newArray;
 }
 void ShowArray(int[] array)

 {
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
 }

int[] binaryArray = SumOfNumbers(8);
ShowArray(binaryArray);
*/
