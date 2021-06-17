using System;
using System.Collections.Generic;
using System.Text;


namespace Blockbuster
{
    class BlockBusterVideo
    {
        public List<Movies> Movies { get; set; } = new List<Movies>();

        //You may only initialize values, but you may call any methods outside of another method
        //Movies.Add(new VHS("Die Hard", Genre.Action, 120, dieHardScenes));

        //Directly in a class, you may only declare and initalize properties and declare methods/constructors

        public BlockBusterVideo()
        {
            //Think of this constructor as stocking our shelves in block buster with Movies

            DVD a = new DVD();
            //Think of this constructor as stocking our shelves in block buster with Movies
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            Movies d = new Movies("Shrek", Genre.Drama, 120, shrekScenes, a);


            List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            Movies d2 = new Movies("Mean Girls", Genre.Comedy, 133, meanGirls, a);
           

            VHS c = new VHS();
            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building", "John McLane sneaks around", "Shoot out by the vault" };
            Movies v = new Movies("Die Hard", Genre.Action, 120, dieHardScenes, c);

            List<string> lordOfTheRingsScenes = new List<string>() { "Hobbiton", "Fireworks", "Mines of Moria", "Orcs attack" };
            Movies v2 = new Movies("Fellowship of the Ring", Genre.Drama, 225, lordOfTheRingsScenes, c);
            //You cant call the constructor on abstract classes
            //In abstract classes constructors exist for the children 
            //Think of the children!
            //Movie m = new Movie("Shrek", Genre.Comedy, 95, shrekScenes);


            Movies.Add(v);
            Movies.Add(v2);
            Movies.Add(d);
            Movies.Add(d2);

        }

        //2 Reasons why we can use the movie class
        //1) Movie is public 
        //2) Movie is in the same namespace as this class
        public Movies GetMovie(int index)
        {
            Movies m = Movies[index ];
            return m;
        }

        public void PrintAllMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movies m = Movies[i];
                string title = m.Title;
                Console.WriteLine($"{i}: {title}");
            }
        }
        public void Checkout()
        {
            Console.WriteLine($"What movie would you like to watch? 1 to {Movies.Count + 1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movies m = GetMovie(index);
            if (index == 0 || index == 1)
            {
                Console.WriteLine("1) Play whole movie or 2) start where you left off? Input Number: ");
                int input1 = int.Parse(Console.ReadLine());
                if (input1 == 1)
                {
                    m.PlayWholeMovie();
                }
                else
                {
                    m.Play(m.Scenes);
                }
            }
            else
            {
                m.Play(m.Scenes);
            }
        }
    }
}
