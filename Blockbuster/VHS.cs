using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //Always make classes, properties public unless to do otherwise
    public class VHS : IPlay
    {
        //We want current time to always start at 0
        //You may give properties initial values 
        public int CurrentTime { get; set; } = 0;

        //Base - reference to the parent class 
        //If the parent has parameters in its constructor, 
        //The child must call base in it's own constructor to pass values up to the parent 
        //Outside of Constructors, base functions much like the this keyword, 
        //but instead of pointing to itself, it point to its immediate parent
        public VHS(string Title, Genre Category, int Runtime, List<string> Scenes) 
        {

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }


        //VHS wants it own version of the play method 
        public void Play(List<string> Scenes)
            {
            List<string> dieHardScenes = new List<string>() { "Plane scene", "Snape takes over the building", "John McLane sneaks around", "Shoot out by the vault" };
            VHS v = new VHS("Die Hard", Genre.Action, 120, dieHardScenes);

            List<string> lordOfTheRingsScenes = new List<string>() { "Hobbiton", "Fireworks", "Mines of Moria", "Orcs attack" };
            VHS v2 = new VHS("Fellowship of the Ring", Genre.Drama, 225, lordOfTheRingsScenes);

            if (CurrentTime < Scenes.Count)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(scene);
                CurrentTime++;
            }
            else
            {
                Rewind();
            }

        }

        public Movie GetMovie(int index)
        {
            Movie m = Movies[index];
            return m;
        }
    }
}
