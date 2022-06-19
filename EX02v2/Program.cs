// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите координаты первой точки - ");
int x1 = Input ("X - ");
int y1 = Input ("Y - ");
int z1 = Input ("Z - ");

Console.WriteLine("Введите координаты второй точки - ");
int x2 = Input ("X - ");
int y2 = Input ("Y - ");
int z2 = Input ("Z - ");

int x = (x2-x1)*(x2-x1);
int y = (y2-y1)*(y2-y1);
int z = (z2-z1)*(z2-z1);

Console.WriteLine (Math.Sqrt(x+y+z));

int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
