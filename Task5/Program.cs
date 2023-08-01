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

int [] CreateArray()
{
    int [,] array = new int[4, 4];
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            while (j != array.GetLength(1))
            {
                array[i, j] = num;
                num++;
                j++;
                if (j == array.Get)
                {
                    
                }
            }
        }
    }
    return...
}


// //     0  1  2  3   
//       0
//       1
//       2
//       3
//         