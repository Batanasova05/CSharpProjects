using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
int star = 1;
int outterDash = n/2;
for (int i = 0; i < n/2+1; i++)
{
Console.WriteLine("{0}{1}{0}",new string('-',outterDash), new string ('*',star), new string('-', outterDash) );
star += 2;
outterDash--;
}


for (int i = 0; i < n; i++)
{
star -= 2;
Console.WriteLine("{0}{1}{0}", "|", new string ('*',n-2),"|");

}
}
    }


