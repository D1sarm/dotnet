// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int M = 5;
int[] arr = new int [M];
int count = 0;
for (int i = 0; i < arr.Length; i++){
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] > 0 ) count++;
}

System.Console.WriteLine(count);