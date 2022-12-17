// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.WriteLine("please enter the 1st no");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("please enter the 2nd no");
int y = int.Parse(Console.ReadLine());

for(int i = x ; i <= y ; i++)
{
    int sum = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
            sum = sum + j;
    }
    if (sum == i)
        Console.WriteLine("\t" + i);
}    

