class Program
{
    static void Main(string[] args)
    {
        // initialize random number generator 
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101); 
        int userGuess = 0;

        Console.WriteLine("Try to guess my number from 1-100");
        // game loop
        while (userGuess != randomNumber)
        {
            Console.Write("Enter your guess: ");
            string guess = Console.ReadLine();

            if (int.TryParse(guess, out userGuess))
            {
                if (userGuess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                // once number is guessed this will be displayed on the console
                {
                    Console.WriteLine($"Congratulations! You guessed my number {randomNumber}!");
                }
            }
            else
            // if nan is given by user
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}