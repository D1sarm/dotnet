// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = {{ 1, 4, 7, 2 },
              { 5, 9, 2, 3 },
              { 8, 4, 2, 4 }};

int[] temp = new int[4];
int n = 4;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        temp[j] = arr[i, j];
    Array.Sort(temp);
    Array.Reverse(temp);
    for (int k = 0; k < n; k++)
    {
        arr[i, k] = temp[k];
        Console.Write($"{arr[i, k]} ");
    }
    Console.WriteLine();
}