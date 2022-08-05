Console.WriteLine("введите три целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int maxim = a;
if (b > maxim)
{
    maxim = b;
}
if (c > maxim)
{
    maxim = c;
}
    Console.Write(maxim);
    Console.WriteLine(" - наибольшее" );