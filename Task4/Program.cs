int [,,] CreateArray2(int strings, int columns, int num, int minrandom, int maxrandom)
{
    Console.WriteLine("Введите МИНИМАЛЬНОЕ возможное значение в элементах массива:");
    minrandom = Convert.ToInt32(Console.ReadLine());

    while (minrandom < 10)
    {
        Console.WriteLine("Введите двузначное минимальное число! : ");
        minrandom = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Введите МАКСИМАЛЬНОЕ возможное значение в элементах массива:");
    maxrandom = Convert.ToInt32(Console.ReadLine());

    while (maxrandom > 99 || maxrandom < minrandom)
    {
        Console.WriteLine("Введите максимальное ДВУЗНАЧНОЕ число! Также оно не должно быть меньше минимального значения:");
        maxrandom = Convert.ToInt32(Console.ReadLine());
    }

    int [,,] arraytwo = new int [strings, columns, num];
    Random random = new Random();
    for (int i = 0; i < arraytwo.GetLength(0); i++)
    {
        for (int j = 0; j < arraytwo.GetLength(1); j++)
        {
            for (int k = 0; k < arraytwo.GetLength(2); k++)
            {
                arraytwo[i, j, k] = random.Next(minrandom, maxrandom);
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return arraytwo;
}



void PrintArray(int [,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.Write($"{mass[i, j, k]} ({i + " "} {j + " "} {k});");
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите кол-во строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 значение:");           //не знаю как назвать
int usernum = Convert.ToInt32(Console.ReadLine());
int usermin = 0;
int usermax = 0;

int [,,] finalarray = CreateArray2(str, col, usernum, usermin, usermax);
PrintArray(finalarray);