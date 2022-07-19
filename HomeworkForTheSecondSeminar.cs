// программa , которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TheSecondDigit(int num)
{
    int dec = num / 10 % 10;
    return dec;
}

int number = new Random().Next(1000);
int nam = TheSecondDigit(number);

Console.WriteLine($"рандомное число {number} , вторая цифра {nam}" );
*/

 //Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int TheThirdDigit(int num)
{
    int mis = - 1;
    int hundreds = num % 10;
     if( num > 99) return hundreds;
     else return mis;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int nam = TheThirdDigit(number);
if(nam == -1)
{
    Console.Write("третьего числа нет");
}
else Console.WriteLine($"заданное число {number}, третье число  {nam}" );
*/

// программа которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool AWeek(int num)
{
if (num > 5 ) return true;
    else return false;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool nam = AWeek(number);
if(nam == true)
{
    Console.Write("да ");
} 
else Console.Write("нет ");
*/