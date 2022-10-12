// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);

int NatSt (num1,num2)
{
    for(int i=0;i<num2;i++)
    {
        num*=num;
    }
    return num;
}

Console.WriteLine(NatSt(a,b));
