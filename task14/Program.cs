// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num);
//int A = num % 100;
if(num / 10 > 1)
{
    int B = num % 10;
    Console.WriteLine(B);
}
else
{
    Console.WriteLine("Error");
}