string[,]table=new string[2,5];
table[1,4]="fuck";
// string.empty
//table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
//table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
//for (int row = 0; row < 2; row++)
//{
  //   for (int columns = 0; columns < 5; columns++)
    // {
    //    Console.WriteLine($"-{table[row,columns]}-");
     //}
//}

int[,] matr=new int [6,6];
void PrintArray(int[,]matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[i,j]} ");
    
    }
    Console.WriteLine();
}}
void FillArray(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j= 0; j < matr.GetLength(1);j++)
    {
        matr[i,j] =new Random ().Next(0,9);
    }
}
}

//PrintArray(matr);
FillArray(matr);
//Console.WriteLine();
PrintArray(matr);

