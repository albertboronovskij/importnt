int[,] matr = new int[4, 4];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write($" 0{matrix[i, j]} ");
            }
            else
            {
                Console.Write($" {matrix[i, j]} ");

            }

        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    int k = 01;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int i = 0;
        matr[i, j] = k;
        k++;

    }
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        int j = 3;
        matr[i, j] = k;
        k++;
    }
    for (int j = 2; j >-1; j--)
    {
        int i = 3;
        matr[i, j] = k;
        k++;

    }
    for (int i = 2; i >0; i--)
    {
        int j = 0;
        matr[i, j] = k;
        k++;
    }
    for (int j = 1; j <3  ; j++)
    {
        int i = 1;
        matr[i, j] = k;
        k++;

    }
    for (int j = 2; j >0; j--)
    {
        int i = 2;
        matr[i, j] = k;
        k++;
    }
}




//PrintArray(matr);
FillArray(matr);
//Console.WriteLine();
//PrintArray(matr);

PrintArray(matr);


