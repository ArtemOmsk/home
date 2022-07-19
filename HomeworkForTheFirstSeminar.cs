/* // программа которая на вход принемает 2 числа и выдаеткакое число больше , а какое меньше.


Console.WriteLine("введите первое чилсо ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine(num1  + " больше "  + num2 );
}
if(num2 > num1)
{
     Console.WriteLine(num2  + " больше "  + num1 );
}

*/
/* // программа которая принимает на вход три числа и выдает максимльное из них.

Console.WriteLine("введите первое чилсо ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if(num2 > num3)
{
    max = num2;
}
else
{
    max = num3;
}
 Console.WriteLine("Наибольшее число " + max);

 */

/* // программа которая на вход принимает число и выдает яыляется ли число четное.

 Console.WriteLine("введите чилсо ");
int num = Convert.ToInt32(Console.ReadLine());

if( num % 2 == 0)

   Console.WriteLine("yes"); 

else
   Console.WriteLine("no"); 
   */

/* // программа которая на входи принимает число , а на выходе показывает все четные числа .

int current = 2;
string check;
int num;
Console.Write("введите целое положительное число  ");
check = Console.ReadLine();
    {
        num = Convert.ToInt32(check);
        if(num < 2) Console.WriteLine("вы ввели число меньше 2.Четных положительных числе в данно диапозоне нет");
        while(current <= num)
        {
            Console.Write(current + " " );
            current = current + 2;
        }
    }
    */

// еще один способ решение последней задачи на нахождения всех четных чисел числа N
/*
Console.WriteLine("введите четное чилсо ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;

while(current <= num)

     if(current % 2 ==0)
     {
        Console.Write(current + " " );
        current = current + 2;
     }
    if(num < 2)
    {
       Console.Write("вы ввели число меньше 2, четных положительных чисел в данном диапозоне нет");
    }
    */
    