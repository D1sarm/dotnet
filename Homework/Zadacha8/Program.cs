// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

void Value(int n){
    int a = 1;
    while(a <= n){
        if(a % 2 == 0){
            Console.Write($"{a}, ");
        }
        a++;
    }
}
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"Чётные числа между 1 и {N} - ");
Value(N);