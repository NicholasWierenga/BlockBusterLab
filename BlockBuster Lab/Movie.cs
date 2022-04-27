using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockBuster_Lab
{
    public enum Category
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action,
    }
    abstract class Movie
    {
        
        public string Title { get; set; }
        public Category MovieCat { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Category MovieCat, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.MovieCat = MovieCat;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title + ".");
            Console.WriteLine("Category: " + MovieCat + ".");
            Console.WriteLine("Runtime(minutes): " + RunTime + " minutes.");
        }

        public void PrintScenes()
        {
            Console.WriteLine();
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine("Scene " + (i + 1) + " is: " + Scenes[i] + ".");
            }
        }

        public bool RunAgain()
        {
            Console.WriteLine("Do you want to continue watching? y/n");

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

        public abstract void Play();
    }
}
