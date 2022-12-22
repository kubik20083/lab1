Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A > B)
{
    Console.WriteLine("Первое число " + A + " больше чем второе " + B);
}
else
{
    Console.WriteLine("Второе число " + B + " больше чем первое " + A);
}