double fibonacce(int n)
{
    if (n==1||n==2) return 1;
    else return fibonacce(n-1) + fibonacce(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i})={fibonacce(i)}");
}