
int a = Console.ReadLine();
 if (GetFourRank(a)== GetFirstRank(a))
{
if (GetThirdRank(a)== GetFiveRank(a))
{
      Console.WriteLine("это число полиндром");


}

else
{
    Console.WriteLine("это число не полиндром");    
}
}
else
{
    Console.WriteLine("это число не полиндром");
    
}
Console.WriteLine(GetThirdRank (a));