// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите числo N - ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    int result = Func(count);
    count=count+1;
    Console.Write($"{result} ");
}

int Func (int a)
{
    return a * a * a;
}
