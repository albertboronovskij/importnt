int []mass ={144,729,68,928,211,353};
int length=6;
int max =0;
int min=mass[0];
int result;
for (int i = 0; i < length; i++)
{
    if (mass[i]>max)
    {
      max=mass[i];
    }
    if (mass[i]<min )
    {
        min=mass[i];
    }
}
result=max-min;
Console.WriteLine(result) ;
