// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double dist(float x1, float y1,
                float z1, float x2,
                float y2, float z2)
{
    double dis = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
    return dis;
}

Console.WriteLine(dist(7, -5, 0, 1, -1, 9));