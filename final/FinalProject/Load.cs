using System;
using System.Diagnostics;

public class Load
{
    public Dictionary<string, double> LoadDictionary()
    {
        Dictionary<string, double> dictionary = new Dictionary<string, double>();
        try
        {
            using (StreamReader sr = new StreamReader("documents.txt"))
            {
                string line = sr.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    Console.WriteLine("File is empty.");
                    return dictionary;
                }

                while (line != null)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        double value = double.Parse(parts[1].Trim());
                        dictionary[key] = value;
                    }
                    line = sr.ReadLine();
                }
            }
            Console.WriteLine("Dictionary loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the dictionary: {ex.Message}");
        }

        return dictionary;
    }
}