using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameComponents;

namespace Day2_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(200, 100, 10, 0);

            NPC[] npcs =
            {
                new DarkWizard(),
                new DarkWizard(),
                new Ork(),
                new Ork()
            };
        }
    }
}


