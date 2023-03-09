int [] mass ={294,862,401,758,283,550};
int Length=6;
int count=0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine(count);