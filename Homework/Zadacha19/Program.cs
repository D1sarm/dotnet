// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void result(int N){
    int a = N/10;
    int b = a/10;
    int c = b/10;
    int d = c/10;
    if(N%10 == d % 10 & a % 10 == c % 10) System.Console.WriteLine($"Число {N} - палиндром");
    else System.Console.WriteLine($"Число {N} - НЕ палиндром");
}
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
result(N);