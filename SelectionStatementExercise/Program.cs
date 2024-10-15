namespace SelectionStatementExercise
{
    public class Program 
    {
        static void Main(string[] args)
        {
            int favNumber = 4; 
            Console.WriteLine("Guess my favorite number:");
            int userInput = int.Parse(Console.ReadLine());
            
            while (userInput != favNumber)
            {
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low. Try again:");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high. Try again:");
                }
                
                userInput = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations! You guessed the correct number: " + favNumber);
        }
    }
}