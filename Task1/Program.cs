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
}

int [,] ArraySort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i,k]) continue;
                int sobst = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = sobst;
            }
        }
    }
    return array;
}

Console.WriteLine("Введите кол-во строк: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] finalarray = CreateArray2(str, col);
PrintArray(finalarray);
Console.WriteLine(" ");
Console.WriteLine("Отсортированный массив:");
int [,] sortarray = ArraySort(finalarray);
PrintArray(sortarray);