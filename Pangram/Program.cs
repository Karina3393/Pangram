namespace Pangram
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Введіть речення:");
            string input = Console.ReadLine().ToLower(); 

      
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

           
            bool isPangram = alphabet.All(c => input.Contains(c));

           
            if (isPangram)
            {
                Console.WriteLine("Речення є панграмою.");
            }
            else
            {
                Console.WriteLine("Речення не є панграмою.");
            }
        }
    }
}
