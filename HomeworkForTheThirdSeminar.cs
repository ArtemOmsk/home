
// программa которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome(int num)
{
  while(num > 99999 || num <10000)
  {
    Console.WriteLine("ошибка! число не пятизначное");
    num = Convert.ToInt32(Console.ReadLine());
  }

  if(num % 10000 == num / 10 && num % 1000 == num / 100) return true;

  else return false;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool nam = Palindrome(number);
if(nam == true)
{
    Console.Write("да ");
} 
else Console.Write("нет ");
*/

//программa которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xa, double ya, double xb, double yb, double za, double zb )
{
double Distance = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za));
return Distance;
}
Console.WriteLine("введите значение координаты Х точки А");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты Y точки A");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты Х точки В");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты Y точки В");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты Z точки A");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение координаты Z точки В");
int zb = Convert.ToInt32(Console.ReadLine());

double distance = Distance(xa, ya, xb, yb, za, zb );
Console.WriteLine($"Расстояние между точками А и В равно {distance}");
*/


int cube(int num)
{
  while(num < 0)
  {
    Console.WriteLine("введите целое число");
    num = Convert.ToInt32(Console.ReadLine());
  }
  num = num *num *num;
  return num;
}
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int nam = cube(number);
Console.WriteLine(nam);