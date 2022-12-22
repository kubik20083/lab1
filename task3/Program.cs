Console.WriteLine("Четное или нечетное число");

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
{
    Console.WriteLine("Число " + num + " не четное");
}
else
{
    Console.WriteLine("Число " + num + " четное");
}