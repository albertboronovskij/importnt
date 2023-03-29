Console.WriteLine("введите n");
string data = Console.ReadLine();
int a = Convert.ToInt32(data);
int b=a;
void counter(string data)

{
    if (b!=0){
   Console.WriteLine(b);
   b--;
   counter(data);}
}
counter(data);
