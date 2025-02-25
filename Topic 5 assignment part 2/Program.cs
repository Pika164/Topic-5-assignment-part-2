namespace Topic_5_assignment_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userGuess, secretNumber;

            secretNumber = 5;

            Console.WriteLine("Hello and welcome to my dumb guessing game:). You will get one guess to guess the secret number.");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.WriteLine();
            Console.Write("Now then, What is your guess on my secret number (1-10)? You'll get a special prize for getting it right. ");
            userGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (userGuess == 5)
            {
                Console.WriteLine("You are Correct! Your prize is getting it correct so horray!");
            }
            else
            {
                Console.WriteLine("Sorry but you got it wrong. You were close though!");
            }
        }
    }
}
