using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    public class BlockBuster
    {
        List<Movie> Movies = new List<Movie> { new DVD("Star Wars", Category.Action, 138, new List<string> { "Not a moon", "Planet blows up",
            "Not-a-moon blows up" }),
        new DVD("Insidious", Category.Horror, 153, new List<string> { "Jumpscare 1", "Jumpscare 2", "Big chase scene", "Good guys win" }),
        new DVD("Reno 911", Category.Comedy, 122, new List<string> { "First arrest", "Policy brutality", "I've been murdered" }),
        new VHS("Up!", Category.Drama, 97, new List<string> { "Going up", "Floating through sky", "Old man is old scene", "Villain chases kid" }),
        new VHS("Cheesy Romcom", Category.Romance, 133, new List<string> { "Generic quirky characters", "Characters are lonely", "Characters don't like eachother",
            "Characters like eachother now" }),
        new VHS("Rocky", Category.Drama, 162, new List<string> { "Intro music that gases the audience up", "Tough guy enters", "Tougher guys fights tough guy",
            "Tougher guy wins", "Planning/training montage", "Tough guys loses again" })};

        public BlockBuster()
        {
        }
        public void PrintMovies()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine("  " + (i + 1) + ") " + Movies[i].Title);
            }
        }

        public void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("What movie would you like to check out?");
            string input = Console.ReadLine().Trim();

            if (int.TryParse(input, out int index) && index >= 1 && index <= Movies.Count)
            {
                Console.WriteLine("You've selected: ");
                Movies[index - 1].PrintInfo();

                do
                {

                    Console.WriteLine("Are you sure you want to watch this film? y/n");
                    string response = Console.ReadLine().ToLower().Trim();

                    if (response == "y")
                    {
                        break;
                    }
                    else if (response == "n")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, I didn't understand that. Let's try again.");
                    }

                } while (true);

                bool playAll = GetResponse("Do you want to watch all the film? y/n");

                if (playAll) // This if is basically a PlayWholeMovie method
                {
                    foreach (string scene in Movies[index - 1].Scenes) 
                    {
                        Console.WriteLine("Now playing: " + scene);
                    }
                }
                else
                {
                    Movies[index - 1].Play();
                }

            }
            else
            {
                Console.WriteLine("That is not a valid index integer. Let's try again.");
                CheckOut();
            }
        }

        public bool GetResponse(string prompt)
        {
            Console.WriteLine(prompt);

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
                Console.WriteLine("I didn't udnerstand that. Let's try again");
                return GetResponse(prompt);
            }
        }
    }
}
