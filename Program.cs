using System;

namespace test
{
    class Programs
    {
        static void Main(string[] args)
        {
            string secretWord = "secret";
            string guessedWord = "";
            int guesses = 0;
            bool OutofGuesses = false;

            do 
            {   if (guesses < 3){
                Console.WriteLine("Guess: ");
                guessedWord = Console.ReadLine().ToLower();
                guesses++;
                }
                else {
                    OutofGuesses = true;
                }                

            } while (secretWord != guessedWord && !OutofGuesses);
            if (OutofGuesses) {
                Console.WriteLine("You lose.");
            } else {
                Console.WriteLine("You win!");
            }
        }            
    }
} 
