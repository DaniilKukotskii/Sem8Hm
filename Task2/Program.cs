int [,] CreateArray2(int strings, int columns)
{
    int [,] array_two = new int [strings, columns];
    Random random = new Random();
    for (int i = 0; i < array_two.GetLength(0); i++)
    {
        for (int j = 0; j < array_two.GetLength(1); j++)
        {
            array_two[i, j] = random.Next(0, 100);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return array_two;
}

void PrintArray(int [,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
        Console.Write(mass[i, j]);
        Console.Write(" ");
        }
        Console.WriteLine();
    }
    // Console.Write(mass[0, 1]);
}

void SumStrings (int [,] array)
{
    int [] onearray = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            onearray[i] += array[i, j];
        }
    }
    int minindex = 0;
    for (int i = 0; i < onearray.Length; i++)
    {
        if (onearray[minindex] > onearray[i]) minindex = i;
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {minindex++}");
}

Console.WriteLine("Введите кол-во строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] finalarray = CreateArray2(str, col);
PrintArray(finalarray);
Console.WriteLine(" ");
SumStrings(finalarray);
