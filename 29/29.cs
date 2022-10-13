// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.

Console.Clear();
Console.Write("Введите числа через запятую: ");
string? text = Console.ReadLine();

// создание функции заполнения массива из строки
char[] Array(string text1)
{
    char[] array = new char[8];  
    char t = ',';
    int l=0;

    for (int i=0; i< text1.Length && i<15; i++)
    {
        if (text1[i] == t) //если есть ","
        {
            i++;
        }
        array[l] = text1[i];
        l++;
    }
    return array;
}

// функция  печати 
void PrintArry(char[] massiv)
{
    int count = massiv.Length;
    Console.Write("[");
    for (int i = 0;i < count;i++)
    {
        Console.Write(massiv[i]);
        if (i < count-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

char[] Mas =  Array(text);
PrintArry(Mas);
