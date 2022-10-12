// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);

int NatSt (int num1,int num2)
{
    int num=num1;
    for(int i=1;i<num2;i++)
    {
        num=num*num1;
    }
    return num;
}

Console.WriteLine(NatSt(a,b));
