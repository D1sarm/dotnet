// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 22;
int b = 33;
int c = 25;

int max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.WriteLine($"max = {max}");
