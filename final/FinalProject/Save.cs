public class Save
{
    public void SaveDictionary(Dictionary<string, double> dictionary)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter("documents.txt"))
            {
                foreach (var kvp in dictionary)
                {
                    sw.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
            Console.WriteLine("Dictionary saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the dictionary: {ex.Message}");
        }
    }
}