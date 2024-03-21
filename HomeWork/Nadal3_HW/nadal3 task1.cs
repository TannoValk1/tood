using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MinimizeWord("Auto"));
        Console.WriteLine(MinimizeWord("A"));
        Console.WriteLine(MinimizeWord("Kalad"));
    }

    static string MinimizeWord(string word)
    {
        if (word.Length < 2)
        {
            return "Liiga lühike sõna!";
        }

        string minimizedWord = "";

        for (int i = 0; i < word.Length; i += 2)
        {
            minimizedWord += word[i];
        }

        return minimizedWord;
    }
}
