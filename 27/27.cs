// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int Sum (int n)
{
    int a1 = n % 10;
    int a2 = n /10 % 10;
    int a3 = n /100 % 10;
    int a4 = n /1000;
    n = a1+a2+a3+a4;
    return n;
}

Console.WriteLine(Sum(N));
