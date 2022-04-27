using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    class DVD : Movie
    {
        public DVD(string Title, Category MovieCat, int RunTime, List<string> Scenes) : base(Title, MovieCat, RunTime, Scenes)
        {
        }

        public override void Play()
        {
            do
            {
                PrintScenes();

                Console.WriteLine();

                Console.WriteLine("What scene would you like to watch? Enter an integer.");
                string input = Console.ReadLine().ToLower().Trim();
                
                if (int.TryParse(input, out int output) && output >= 1 && output <= Scenes.Count)
                {
                    Console.WriteLine();
                    Console.WriteLine("Now playing: " + Scenes[output - 1]);
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't quite get that. Let's try again.");
                }

            } while (RunAgain());

            
        }
    }
}
