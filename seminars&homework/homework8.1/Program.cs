int[,] matr = new int[4, 6];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 9);
        }
    }
}
void srawnenie1(int[,] matr)
{
    int count1 = 0;
    int u = 0;
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        count1 = count1 + matr[u, i];
    }
    //Console.WriteLine($"первая строка ={count}");
    u++;
    int count2 = 0;

    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        count2 = count2 + matr[u, i];
    }
    //Console.WriteLine($"вторая строка ={count1}");
    u++;
    int count3 = 0;

    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        count3 = count3 + matr[u, i];
    }
    //Console.WriteLine($"третяя строка ={count2}");
    u++;

    int count4 = 0;

    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        count4 = count4 + matr[u, i];
    }
    //Console.WriteLine($"четвёртая строка ={count3}");

    int Min(int arg1, int arg2, int arg3, int arg4)
    {
        int result = arg1;
        if (arg2 < result) result = arg2;
        if (arg3 < result) result = arg3;
        if (arg4 < result) result = arg3;
        return result;
    }
    int min = Min(count1, count2, count3, count4);

    if (min == count1)
    {
        Console.Write(" первая строка наименьшая ");
    }
    if (min == count2)
    {
        Console.Write(" вторая строка наименьшая ");
    }
    if (min == count3)
    {
        Console.Write(" третяя строка наименьшая ");
    }
    if (min == count4)
    {
        Console.Write(" четвёртая строка наименьшая ");

    }
}

Console.Write(min);

FillArray(matr);
//Console.WriteLine();


PrintArray(matr);
srawnenie1(matr);





