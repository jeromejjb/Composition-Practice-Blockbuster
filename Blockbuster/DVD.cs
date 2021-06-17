using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public class DVD : IPlay
    {
        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes) 
           
        {

        }

        public void Play(List<string> Scenes)
        {
            List<string> shrekScenes = new List<string>() { "What are you doing in my swamp", "Shrek meets Donkey", "Castle scene", "Dragon fight scene" };
            DVD d = new DVD("Shrek", Genre.Drama, 120, shrekScenes);

            List<string> meanGirls = new List<string>() { "First day at school", "You must wear pink on Wednesdays", "Riot scene", "Who's afraid of Regina?" };
            DVD d2 = new DVD("Mean Girls", Genre.Comedy, 133, meanGirls);

            Console.WriteLine($"Select what scene you'd like to watch: 0 to {Scenes.Count-1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            string scene = Scenes[index];
            Console.WriteLine(scene);

        }
    }
}
