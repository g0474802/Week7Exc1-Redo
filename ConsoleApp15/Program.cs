using System;
using System.IO;

class Program
{
    // Method to count words in a file
    static int CountWords(string fileName)//method that takes the file name as input and returns an integer 
    {
        try
        {
            string content = File.ReadAllText(fileName);
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
            return 0;
        }
    }

    static void Main(string[] args)
    {
        
        string filePath = "ProjFile.txt";

        int wordCount = CountWords(filePath);
        Console.WriteLine("Total number of words in the file: " + wordCount);
    }
}
