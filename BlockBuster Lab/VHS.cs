using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    class VHS : Movie
    {
        public int CurrentScene { get; set; }

        public VHS(string Title, Category MovieCat, int RunTime, List<string> Scenes) : base(Title, MovieCat, RunTime, Scenes)
        {
        }


        public override void Play()
        {
            do
            {
                if (CurrentScene == Scenes.Count)
                {
                    Console.WriteLine("Rewinding and starting from the beginning.");
                    Rewind();
                }
                Console.WriteLine();
                Console.WriteLine(Scenes[CurrentScene]);
                CurrentScene++;

                if (CurrentScene == Scenes.Count)
                {
                    Console.WriteLine("You've watched all the film. Continuing to watch will rewind the film to the start.");
                }

            } while (RunAgain());
            
            
        }
        public void Rewind()
        {
            CurrentScene = 0;
        }
    }
}
