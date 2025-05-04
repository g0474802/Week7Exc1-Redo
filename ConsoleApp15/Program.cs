using System;
using System.IO;

class Program
{
    
    static int CountWords(string fileName)// Method to count words in a file
    {
        try
        {
            string content = File.ReadAllText(fileName);//reads the entire file into a string
            string[] words = content.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);//removes any blanks
            return words.Length;
        }
        catch (Exception ex)//if an error happens while reading the file, shows an error message
        {
            Console.WriteLine("Error reading file: " + ex.Message);//message output
            return 0;
        }
    }

    static void Main(string[] args)
    {
        
        string filePath = "ProjFile.txt";//declares filePath string

        int wordCount = CountWords(filePath);//decalre wordCount as the CountWords method
        Console.WriteLine("Total number of words in the file: " + wordCount);//outputs word count
    }
}
