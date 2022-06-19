// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное числo - ");
string input = Console.ReadLine();
int a = input.Length;
int b=1;
int c=2;
int d=3; 
int e=4;

if (a==5)
    {
    b = input[0];
    c = input[1];
    d = input[3];
    e = input[4]; 
    
        if (b == e || c == d)
        {
        Console.WriteLine("Данное число является палиндромом.");
        }
        if (b != e && c != d)
        {
        Console.WriteLine("Данное число не является палиндромом.");
        }
    }

if (a != 5)
{
    Console.WriteLine("Вы ввели неправильное число!");
}
