int Summ(int digit)
{
   int delDigit = 0;
   int summDigit = 0;
   while (digit > 0)
   {
        delDigit = digit % 10;
        summDigit = summDigit + delDigit;
        digit = digit / 10;
   } 
   return summDigit;
}
int number = Summ(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"сумма чисел = {number}");