int[] myArray = new int[8];
Random rand = new Random();
for (int i = 0; i < myArray.Length -1; i++)
    {
        myArray[i] = rand.Next(100);
        Console.Write($"{myArray[i]}, ");
    }
myArray[7] = rand.Next(100);
Console.WriteLine($"{myArray[7]}.");
