using System;
class TotalPoints
{
    static void Main2()
    {
        TotalPoints answer=new TotalPoints();
        answer.Calculate();
    }
     void Calculate()
    {
        TotalPoints game = new TotalPoints();
        Console.Write("Enter number of wins: ");
        int wins = int.Parse(Console.ReadLine());
        Console.Write("Enter number of draws: ");
        int draws = int.Parse(Console.ReadLine());
        Console.Write("Enter number of looses: ");
        int losses = int.Parse(Console.ReadLine());
        int result = game.CalculateTotalPoint(wins, draws, losses);
        Console.WriteLine($"Total points of the team is {result}.");
    }

    int CalculateTotalPoint(int wins, int draws, int losses)
    {
        int total = 0;
        for (int i=0; i<wins; i++)
        {
            total += 5;
        }
        for (int i=0; i<draws; i++)
        {
            total += 2;
        }
        return total;
    }
}