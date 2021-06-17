using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public class DVD : IPlay
    {
        private string v1;
        private Genre comedy;
        private int v2;
        private List<string> meanGirls;

        public DVD()
        {
        }

        public DVD(string v1, Genre comedy, int v2, List<string> meanGirls)
        {
            this.v1 = v1;
            this.comedy = comedy;
            this.v2 = v2;
            this.meanGirls = meanGirls;
        }

        public void Play(List<string> Scenes)
        {
            int index = 0;
            foreach (string Scene in Scenes)
            {
                Console.WriteLine($"{index} : {Scene}");
                index++;
            }
            Console.WriteLine($"Select what scene you'd like to watch: 1 to {Scenes.Count -1}");
            string input = Console.ReadLine();
            int input1 = int.Parse(input);

            string scene = Scenes[input1];
            Console.WriteLine(scene);

        }
    }
}
