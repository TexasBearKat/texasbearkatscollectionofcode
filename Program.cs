namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {string secretWord = "secret";
            string guess = "";
            do{
                Console.WriteLine("\nGuess: ");
                guess = Console.ReadLine();
            }while (secretWord != guess);    
            Console.WriteLine("You win!");}            
    }
} 





