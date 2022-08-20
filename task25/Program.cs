Console.WriteLine("Введите число 'a'");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b'");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;
for ( int number = 2; number <= b; number++)
{
    degree*= a;
}
Console.WriteLine($"a^b -> {degree}");   


