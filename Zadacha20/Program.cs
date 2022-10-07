// 20. Задать номер четверти, показать диапазоны для возможных координат

void Print(int N){
    if(N == 1) Console.WriteLine("Для первой четверти диапазон равен x > 0, y > 0");
    if(N == 2) Console.WriteLine("Для второй четверти диапазон равен x < 0, y > 0");
    if(N == 3) Console.WriteLine("Для третей четверти диапазон равен x < 0, y < 0");
    if(N == 4) Console.WriteLine("Для четвёртой четверти диапазон равен x > 0, y < 0");
}

Console.WriteLine("Введите номер четверти");
int N = Convert.ToInt32(Console.ReadLine());
Print(N);
