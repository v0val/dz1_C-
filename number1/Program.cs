Console.WriteLine("введите два целых числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write(a);
    Console.WriteLine(" - наибольшее" );
    Console.Write(b);
    Console.WriteLine(" - наименьшее" );
}
if (a < b)
{
    Console.Write(b);
    Console.WriteLine(" - наибольшее" );
    Console.Write(a);
    Console.WriteLine(" - наименьшее" );
}
if (a == b)
{
    Console.Write(a);
    Console.Write(" = " );
    Console.Write(b);
}