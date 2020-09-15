//write C# method that returns true if sum of both numbers is greater than 500 else returns false.
using System;
class FirstSum
{
    static void Main1()
    {
        FirstSum z=new FirstSum();
        z.Sum();
    }
    void Sum()
    {
        Console.Write("Input first Number: ");
        string firstnum = Console.ReadLine();
        int x = int.Parse(firstnum);
        Console.Write("Input second Number: ");
        string secondnum = Console.ReadLine();
        int y = int.Parse(secondnum);
        bool check =x + y > 500;
        Console.WriteLine($"Result: {check}");
    }
}
