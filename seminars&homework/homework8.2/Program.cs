int[,] matr = new int[4,4 ];
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
{ int k =1;

    for (int j = 0; j <matr.GetLength(1) ; j++)
    {int i = 0;
        matr[i, j] = k;
        k++;

    }
    for (int i = 1; i <4 ; i++)
  
    {int j = 3;
        matr[i, j] = k;
        k++;
}}
//PrintArray(matr);
FillArray(matr);
//Console.WriteLine();
//PrintArray(matr);

PrintArray(matr);


