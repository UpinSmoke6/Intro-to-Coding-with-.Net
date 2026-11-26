for (int i = 0; i < 3; i++)
{ 
    Console.WriteLine("Next Level:");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine($"{j}: { new string('*', j + 1)}");
    }
    for (int j = 10; j >= 0; j--)
    {
        Console.WriteLine($"{j}: { new string('*', j + 1)}");
    }
}