namespace BlockBuster_Lab
{
    public class Program
    {
        public static void Main()
        {
            BlockBuster b = new BlockBuster();

            Console.WriteLine("Welcome to BlockBuster!");

            do
            {
                Console.WriteLine("Here's a list of movies: ");

                b.CheckOut();

            } while (RunAgain());

            Console.WriteLine("Goodbye!");
        }

        public static bool RunAgain()
        {
            Console.WriteLine("Is there another movie you'd like to watch? y/n");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I didn't get that. Let's try again.");
                return RunAgain();
            }
        }
    }
}
