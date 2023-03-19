double factorial(int n)
{
if (n==1) return 1;
else return n* factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}!={factorial(i)}");

}
