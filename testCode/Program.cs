using System;
using System.Text.RegularExpressions;

namespace testCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Kindness keeps kindling the key to knowledge; keep knocking, keep knowing.";
            string text2 = "Call me on 123-554-7890 or 123-456-7890";
            string text3 = "Ångest är en känsla av överflöd, ibland älskar vi och ibland dör vi.";
            string namePattern = @"\bK\w*";
            string namePatternNew = @"\b[Kk]\w*";
            string namePattern2 = @"\d{3}-\d{3}-\d{4}";
            string vowels = "[aeiouyåäö]";

            Console.WriteLine("\nWords that start with K or k:");
            Console.WriteLine("\nFound Phone numbers:");

            OutputLoop(namePattern, text1, "\nWords that start with K:");
            OutputLoop(namePatternNew, text1, "\nWords that start with K/k:");
            OutputLoop(namePattern2, text2, "\nFound Phone numbers:");
            Vowels(vowels, text3, "\nVowels in text:");
        }

        static void OutputLoop(string pattern, string text, string title)
        {
            Console.WriteLine(title);
            foreach (Match match in Regex.Matches(text, pattern))
            {
                Console.WriteLine(match.Value);
            }
        }
        static void Vowels(string pattern, string text, string title)
        {
            Console.WriteLine(title);
            string markedText = Regex.Replace(text, pattern, m => $"({m.Value})");
            Console.WriteLine(markedText);
        }
    }
}