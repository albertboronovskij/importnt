int a=12361;
int GetFirstRank(int a)
{
while (a>9)
{
    a/=10;
}
return a%10;
}
int GetSecondRank(int a)
{
while (a>99)
{
    a/=10;
}
return a%10;
}
int GetFourRank(int a)
{
while (a>9999)
{
    a/=10;
}
return a%10;
}
int GetFiveRank(int a)
{
while (a>99999)
{
    a/=10;
}
return a%10;
}
int b=GetFirstRank(a);
int c=GetSecondRank(a);
int d=GetFourRank(a);
int e=GetFiveRank(a);

if (b==e&c==d)
 //(GetFirstRank(a)==(GetFiveRank(a)));(GetSecondRank(a)==(GetFourRank(a) ));
{
    Console.WriteLine("это полиндром");



    
}

else
{
    Console.WriteLine("это He полиндром");
}
//(GetFirstRank(a));
//Console.Writeline(GetSecondRank(a));
//Console.Writeline(GetFourRank(a));
//Console.Writeline(GetFiveRank(a));