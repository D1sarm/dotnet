// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double b1,k1,k2,b2,x,y;

Console.Write("b1 = ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
k2 = Convert.ToDouble(Console.ReadLine());

x = (b2-b1)/(k1-k2);
y = (k1*(b2-b1))/(k1-k2)+b1;

System.Console.WriteLine($"({x};{y})");