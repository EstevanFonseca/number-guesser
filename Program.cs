using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();
            while (true) { 

            //Create new randow object
            Random random = new Random();
            int correctNumber = random.Next(1, 10);

            //Intit guess vat 
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number btween 1 and 10");

            while (guess != correctNumber) {
                //Get user input
                string input = Console.ReadLine();

                //Make sure its a number
                if (!int.TryParse(input, out guess))
                {
                    //Print error message
                    PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    //Keep going
                    continue;
                }
                //Get to int and put guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correctNumber)
                {
                 //Print error message
                 PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }
            }

            //Print success message
            PrintColorMessage(ConsoleColor.Yellow, "Correct! You guessed it");
            

            //Ask to play again
            Console.WriteLine("Play again? (Y or N)");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "W")
                {
                    return;
                }
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }

        static void GreetUser()
        {

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            //Tell user its wrong number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
