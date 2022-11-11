// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// 2 4 | 3 4
// 3 2 | 3 3

int[,] matrix1 = new int[2, 2] { { 2, 4 },
                                 { 3, 2 } };
int[,] matrix2 = new int[2, 2] { { 3, 4 },
                                 { 3, 3 } };
Console.WriteLine("Результирующая матрица будет:");
int[,] matrix3 = new int[2, 2];
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        matrix3[i, j] = 0;
        for (int k = 0; k < 2; k++)
        {
            matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(matrix3[i, j] + " ");
    }
    Console.WriteLine();
}