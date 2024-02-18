using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Threading.Tasks.Dataflow;

public class Word
{
    private int[] _setValue;
    public void Hide()
    {
        Scripture s = new Scripture("O how great is the nothingness of the children of men; yea, even they are less than the dust of the earth. For behold, the dust of the earth moveth hither and thither, to the dividing asunder, at the command of our great and everlasting God.");
        string[] scripture = s.Getscripture().Split(" ");
        List<int> set = [];
        foreach (string script in scripture)
        {
            set.Add(0);
        }
        _setValue = set.ToArray();
    }
    public string Hider()
    {
        Random rand = new Random();
        int pick = 0;
        Scripture s = new Scripture("O how great is the nothingness of the children of men; yea, even they are less than the dust of the earth. For behold, the dust of the earth moveth hither and thither, to the dividing asunder, at the command of our great and everlasting God.");
        string[] scripture = s.Getscripture().Split(" ");
        int[] set = _setValue;
        while (pick != 1)
        {
            int r = rand.Next(0, scripture.Count() - 1);
            if (set[r] == 0)
            {
                scripture[r]= string.Concat(System.Linq.Enumerable.Repeat("_", scripture[r].Length));
                set[r] = 1;
                _setValue = set;
                pick = 1;
            }
        }
        return String.Join(" ", scripture);
    }
    public string Getanswer()
    {
        return String.Join(" ", _setValue);
    }
}