// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = 10;
int b = 2;
int max = 0;
int min = 0;

if(a>b){
    max = a;
    min = b;
}
else{
    max = b;
    min = a;
}

Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");