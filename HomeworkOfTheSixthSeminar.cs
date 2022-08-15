// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Сounting(int  nam1, int nam2, int nam3, int nam4, int nam5)
{
   int sum = 0;
    if(nam1 > 0) sum++;
     if(nam2 > 0) sum++;
      if(nam3 > 0) sum++;
       if(nam4 > 0) sum++;
        if(nam5 > 0) sum++;
        return sum;
}


Console.WriteLine("введите 5 чисел");
Console.WriteLine("введите первое чисело");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе чисело");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье чисело");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите четвертое чисело");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите пятое чисело");
int num5 = Convert.ToInt32(Console.ReadLine());
int counting = Сounting(num1, num2, num3, num4, num5);

Console.WriteLine($"положительных чисел {counting}");
*/

//Программа которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

string LineInter( double a, double b, double aa, double bb)
{
        string result = string.Empty;
        double x = (bb - b) / (a-aa);
        double y = a * x * b;
        return result = x + "," + y;
}

Console.Write("введите b1 ");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("введите k1 ");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("введите b2 ");
double b2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("введите k2 ");
double k2 = Convert.ToUInt32(Console.ReadLine());

Console.Write(LineInter(k1, b1, k2, b2));