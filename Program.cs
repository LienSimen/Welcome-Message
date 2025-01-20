namespace Modul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> language = new()
            {
                { "fr", "Buongiorno" },
                { "en", "Good Morning" },
                { "no", "God Morgen" },
                { "de", "Guten Morgen" }
            };

            Console.WriteLine("Whats your name?");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("No input recieved");
                return;
            }
            userInput = userInput.Trim();
            var toLower = userInput.ToLower();
            // ! to tell compiler it wont be null here as we do the check above
            var formattedName = char.ToUpper(toLower![0]) + toLower.Substring(1);

            Console.WriteLine("Where are you from? (fr / en / no / de)");
            string? userLanguage = Console.ReadLine();

            if (string.IsNullOrEmpty(userLanguage))
            {
                Console.WriteLine("Please pick a language");
                return;
            }
            else
            {
                // to avoid adding every combination to dictionary
                userLanguage = userLanguage.ToLower();
                // TryGetValue checks if key exists in dictionary and retrieves associated value that we place in variable "greeting"
                if (language.TryGetValue(userLanguage, out string? greeting))
                {
                    Console.WriteLine($"{greeting}, {formattedName}!");
                }
                else
                {
                    // defaulting to english
                    Console.WriteLine($"Good Morning, {formattedName}!");
                }
                DateTime currentTime = DateTime.Now;
                if (currentTime.Hour >= 4 && currentTime.Hour < 6)
                {
                    Console.WriteLine($"Early Worm! Its currently {currentTime:T}");
                }
                else if (currentTime.Hour >= 6 && currentTime.Hour < 8)
                {
                    Console.WriteLine($"Early Bird! Its currently {currentTime:T}, Time for work");
                }
                else if (currentTime.Hour >= 8 && currentTime.Hour < 10)
                {
                    Console.WriteLine($"Its getting late! Its currently {currentTime:T}");
                }
                else
                {
                    Console.WriteLine($"Try again tomorrow. Its currently {currentTime:T}");
                }
            }
        }
    }
}
