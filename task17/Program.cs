//17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = int.Parse(Console.ReadLine());

if(A == B * B)
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("Не является квадратом");
}