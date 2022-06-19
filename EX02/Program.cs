// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
int x1 = Input ("XA - ");
int y1 = Input ("YA - ");
int z1 = Input ("ZA - ");

int x2 = Input ("XB - ");
int y2 = Input ("YB - ");
int z2 = Input ("ZB - ");

int x = Result (x1, x2);
int y = Result (y1, y2);
int z = Result (z1, z2);

Console.WriteLine (Math.Sqrt(x+y+z));

int Result (int a, int b)
{
    return (b - a)*(b - a);
}

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}