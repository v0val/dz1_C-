Console.WriteLine("введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write(a);
    Console.WriteLine(" - чётное" );
}
else
{
    Console.Write(a);
    Console.WriteLine(" - не является чётным" );
}
   