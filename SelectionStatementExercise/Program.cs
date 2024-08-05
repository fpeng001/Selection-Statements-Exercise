namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 5);
            int userInput;
            do
            {
                Console.WriteLine("Try to guess my favorite number!");
                userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (userInput != favNumber);
            

            
        }
    }
}
