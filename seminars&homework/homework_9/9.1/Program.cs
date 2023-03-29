Console.WriteLine("введите n");
string data = Console.ReadLine();
void counter(string data)
{
    int n = Convert.ToInt32(data);
    int one = 1;
    while (one < n + 1)
    {
        Console.Write($"{one} ");
        one++;
    }
}
counter(data);
