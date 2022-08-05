Console.WriteLine("введите натуральное число > 1");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i += 2)
{
    Console.Write(i);
    Console.Write(" ");
}