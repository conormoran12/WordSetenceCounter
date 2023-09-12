namespace WordSetenceCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph:");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Characters: {userInput.Length}");
            Console.WriteLine($"Words: {userInput.Split(" ").Length}");
            Console.WriteLine($"Sentences: {userInput.Split(". ").Length}");
        }
    }
}