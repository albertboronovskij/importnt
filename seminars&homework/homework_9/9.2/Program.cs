Console.WriteLine("введите n");
string data = Console.ReadLine();
Console.WriteLine("введите m");
string data1 = Console.ReadLine();
void counter(string data)
{
    int n = Convert.ToInt32(data);
    int m = Convert.ToInt32(data1);
    int count= 0;
    while (n < m + 1)
    {

       count =count +n;
        n++;
        
    }
    Console.WriteLine(count);
}
counter(data);