using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberShield3
{
    internal class Shield
    {
        public static void PlayGreeting()

        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("greeting.wav"))
                {
                    player.Play();
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠ Warning: Could not play greeting audio. Make sure 'greeting.wav' is available.");
                Console.ResetColor();
            }
        }

        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

         / ____|    (_)      / ____| |   (_)    | |    
      | |     _ __ _  ___ | (___ | |__  _  ___| | __ 
      | |    | '__| |/ _ \\ \\___ \\| '_ \\| |/ _ \\ |/ / 
         | |____| |  | |  __/ ____) | | | | |  __/   < 
       \\_____|_|  |_|\\___||_____/|_| |_|_|\\___|_|\\_\\ 
          
");
            Console.ResetColor();
        }

        public static string GetResponse(string input)
        {
            switch (input)
            {
                case "how are you?":
                case "how are you":
                    return "I'm just a bot, but I'm here to help you stay safe online!";

                case "what’s your purpose?":
                case "what is your purpose":
                case "what do you do?":
                    return "I provide cybersecurity awareness and tips to help you stay safe from online threats.";

                case "what can i ask you about?":
                case "topics":
                    return "You can ask me about phishing, password safety, safe browsing, and more.";

                case "what is phishing?":
                case "explain phishing":
                    return "Phishing is a scam where attackers trick you into giving personal info via fake emails or websites.";

                case "how do i create a strong password?":
                case "password tips":
                    return "Use a mix of uppercase, lowercase, numbers, and symbols. Avoid common words and never reuse passwords!";

                case "how do i browse safely?":
                case "safe browsing tips":
                    return "Keep your browser updated, avoid suspicious links, and always use HTTPS websites.";

                default:
                    return "I didn't quite understand that. Could you rephrase or ask something else about cybersecurity?";
            }
        }

        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20); // Simulates typing effect
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {

            // Play Voice Greeting
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.Play();
            Shield.PlayGreeting();
            // Display ASCII Art
            Shield.DisplayAsciiArt();

            // Welcome Message and User Interaction
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nHello! What is your name? ");
            string userName = Console.ReadLine()?.Trim();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Guest"; // Default name if none is entered
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome, {userName}! I am CyberShield, your Cybersecurity Awareness Bot.");
            Console.WriteLine("Ask me about online safety, and I'll provide guidance.");
            Console.WriteLine("Type 'exit' anytime to leave the conversation.\n");
            Console.ResetColor();

            // Chat Loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.ResetColor();
                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(userInput)) continue;

                if (userInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Goodbye! Stay safe online.");
                    Console.ResetColor();
                    break;
                }

                // Handle user queries using Shield class
                string response = Shield.GetResponse(userInput);

                Console.ForegroundColor = ConsoleColor.Blue;
                Shield.TypeEffect($"CyberShield: {response}\n");
                Console.ResetColor();
            }
        }
    }
}

