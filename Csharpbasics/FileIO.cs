using System;
using System.IO ;
public class FileIO
{
    public void LearnFileHandling()
    {
        string fileName = "file.txt";
        if (File.Exists(fileName))
        {

            string fileContent = File.ReadAllText (fileName);
            Console.WriteLine (fileContent);
        }
        File.WriteAllText (fileName, "This is just a test file");

    }
    public void LearnFileInfo()
    {
        string fileName ="file.txt";
        FileInfo fileInfo = new FileInfo (fileName);
        var size = fileInfo.Length;
        var createdDate = fileInfo.CreationTime;
        Console.WriteLine($"File Size : {size} bytes");
        Console.WriteLine($"created: {createdDate}");
    }
    public void LearnDirectories()
    {
        string directoryName ="A";
        Directory.CreateDirectory(directoryName);
    }
    //Q: Create afolder "ABC", create 10 subfolders in "ABC". Each subfolder should contain a c# file with hello world program.
}