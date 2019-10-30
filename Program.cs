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
            Map map = new Map(500, 500);
            Player player = new Player(200, 100, 200, 200);

            DarkWizard darkWizard = new DarkWizard("Wizard", 100, 40, 40, 400, 450, 20);
            Ork ork = new Ork();
        }
    }
}


