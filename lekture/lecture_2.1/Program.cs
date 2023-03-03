int []array={11,12,13,14,15,16,16,18,19,10};

int n= array.Length; 
int find =16;

int index=0;

while (index<n)
{
    if (array[index]==find){
        Console.WriteLine(index);
        break;
    }
    index++;
}
