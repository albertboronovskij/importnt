int[,] matr = new int[4, 4]; //задание 54
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
void pattern(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int u = 0; u < matr.GetLength(1); u++)
        {
            for (int j = 0; j < matr.GetLength(0) - 1; j++)
            {
                if (matr[u, j] > matr[u, j + 1])
                {
                    int z = matr[u, j];
                    matr[u, j] = matr[u, j + 1];
                    matr[u, j + 1] = z;
                }
            }

        }
    }
}

//
//PrintArray(matr);
FillArray(matr);
//Console.WriteLine();
PrintArray(matr);
pattern(matr);
//PrintArray(matr);


