// See https://aka.ms/new-console-template  for more information
int n1, n2, i,temp;
Console.WriteLine("n1");                                   
 n1 = int.Parse(Console.ReadLine());                   
Console.WriteLine("n2");                                 
n2 = int.Parse(Console.ReadLine());                
if (n1 > n2)
{
    temp = n1;
    n1 = n2;
    n2 = temp;
}
while (n1<n2)
{
    bool flag = true;
    for (i = 2; i < n1; i++)
    {
        if (n1 % i == 0)
        {
            flag = false; break;
        }
}
    if (flag == true)
     Console.WriteLine("\t" + n1);
    n1++;
}
Console.ReadLine();

