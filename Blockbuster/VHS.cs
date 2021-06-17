using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    //Always make classes, properties public unless to do otherwise
    public class VHS : IPlay
    {
        private string v1;
        private Genre action;
        private int v2;
        private List<string> dieHardScenes;

        public VHS()
        {
        }

        public VHS(string v1, Genre action, int v2, List<string> dieHardScenes)
        {
            this.v1 = v1;
            this.action = action;
            this.v2 = v2;
            this.dieHardScenes = dieHardScenes;
        }

        //We want current time to always start at 0
        //You may give properties initial values 
        

        //Base - reference to the parent class 
        //If the parent has parameters in its constructor, 
        //The child must call base in it's own constructor to pass values up to the parent 
        //Outside of Constructors, base functions much like the this keyword, 
        //but instead of pointing to itself, it point to its immediate parent


        //VHS wants it own version of the play method 
        public int CurrentTime { get; set; } = 0;
        public void Play(List<string> Scenes)
            {
             string userAnswer = "YES";
            while (userAnswer == "YES")
            {
                if (CurrentTime < Scenes.Count)
                {
                    string scene = Scenes[CurrentTime];
                    Console.WriteLine($"Time ({CurrentTime}) : {scene}");
                    CurrentTime++;
                    Console.Write("\nWould you like to play next scene? Y/N");
                    string input = Console.ReadLine();

                    if (input.ToUpper() == "Y" || input.ToUpper() == "YES")
                    {
                        userAnswer = "YES";
                    }
                    else if (input.ToUpper() == "N" || input.ToUpper() == "NO")
                    {
                        userAnswer = "NO";
                    }
                }
                else
                {
                    Console.WriteLine("The movie has ended");
                    Rewind();
                    userAnswer = "NO";
                }
            }
        }

        public void Rewind()
        {
            CurrentTime = 0;

        }
    }
}
