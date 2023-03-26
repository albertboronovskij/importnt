int[,] matr = new int[2, 2];
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(2); j++)
            {
                Console.Write($" {matrix[i,k, j]} ");

            }
            Console.WriteLine();
        }
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
//
//PrintArray(matr);
FillArray(matr);
//Console.WriteLine();
PrintArray(matr);
//pattern(matr);
//PrintArray(matr);


