using System;
class GetNames
{
    public class Initials
    {
        internal string GetInitials(string name)
        {
            string initials = "";
            int len = name.Length;
            int i = 0;
            initials += name[0];
            for(i = 0; i < len; i++)
            {
                if (name[i] == ' ')
                {
                    initials += name[++i];
                    break;
                }
            }
            return initials;
        }
    }
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("Read Initials::->");
        Initials initials = new Initials();
        Console.Write("Enter The Name::");
        string result = initials.GetInitials(Console.ReadLine());
        Console.WriteLine($"The Initials are: {result}");
    }
} 

