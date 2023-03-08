int[] arr = {4,6,3,5,1,7,2,9,8};
void PrintArray ( int[] array)
{
    int count= array.Length;
for (int i = 0; i < count; i++)
{
 Console.Write($"{array[i]}");

}
Console.WriteLine ();
}
PrintArray(arr);
void SelectionSort(int[]array)
{
for (int i = 0; i < array.Length; i++)
{
    int minpos=i;
for (int j = i  ; j< array[minpos]; j++)
{
    if (array[j]<array[minpos]);
}

     
    int temporary=array[i];
    array[i]=array[minpos];
    array[minpos]=temporary; 

}
}
PrintArray(arr);
SelectionSort();