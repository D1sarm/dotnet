// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] arr = {{ 1, 4, 7, 2 },
              { 5, 9, 2, 3 },
              { 8, 4, 2, 4 },
              { 5, 2, 6, 7 }};


int line = 0, minsum = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i, j];
    }
    if (minsum > sum | minsum == 0)
    {
        minsum = sum;
        line = i;
    }
}
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {line + 1}");