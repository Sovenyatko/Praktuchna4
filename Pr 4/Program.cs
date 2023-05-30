using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рядок слiв: ");
        string input = Console.ReadLine();
        Console.Write("Введiть лiтеру: ");
        char letter = Char.ToLower(Console.ReadKey().KeyChar);
        
        string[] words = input.Split(' ');
       
        Console.WriteLine("\nСлова, що починаються на лiтеру '{0}':", letter);

        foreach (string word in words)
        {
            if (Char.ToLower(word[0]) == letter)
            {
                Console.WriteLine(word);
            }
        }
    }
}
