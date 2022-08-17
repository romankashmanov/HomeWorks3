/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Qube (int number)
{
    int i = 1;
    while(i<=number)
    {
        Console.Write(i*i*i + " ");
        i++;
    }
}
Console.Write("Enter a natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Table of cubes of numbers from 1 to " + num + " : " );
Qube(num);

*/


/*

 // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double Length(double x1,  double y1, double z1, double x2,  double y2, double z2)
{
    double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return l;
}
Console.Write("the coordinate of the first point on the axis X: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("the coordinate of the first point on the axis У: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("the coordinate of the first point on the axis Z: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("the coordinate of the second point along the axis Х: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("the coordinate of the second point along the axis У: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write(" the coordinate of the second point along the axis Z: ");
double zB = Convert.ToDouble(Console.ReadLine());
double len = Length (xA, yA, zA, xB, yB, zB);
Console.WriteLine($"The distance between the specified points is equal to {len}");

*/


/*

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void Palindrome(string strPal)                             
{
  if (strPal[0] == strPal[4] && strPal[1] == strPal[3])    
    Console.WriteLine($"The number is palindromic");   
    
  else
    Console.WriteLine($"The number is not palindromic");  
}
Console.WriteLine("Enter a five-digit number: ");             
int number = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(number);
Palindrome(str);

*/
