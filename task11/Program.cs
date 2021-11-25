int numA = new Random().Next(10, 100); // 1 2 3 4 ... 9
Console.WriteLine(numA);

int a = numA/10;
int b = numA%10;

if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
}