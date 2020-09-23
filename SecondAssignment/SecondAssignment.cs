
using System;
using System.IO;
using System.Linq;
public class FileIO
{
    public void LearnDirectories()
    {
        Directory.CreateDirectory(@"../ABC");
        string fileHello = File.ReadAllText("Hello.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"../ABC/{i + 1}Folder");
            File.WriteAllText($"../ABC/{i + 1}Folder/Hello.cs", fileHello);
        }
    }
    static void Main (string[] args)
    {
        FileIO fileIO = new FileIO();
        fileIO.LearnDirectories();
    }
}