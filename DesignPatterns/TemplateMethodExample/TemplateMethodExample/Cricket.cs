using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{
    public class Cricket : Game
    {
        public override void endPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        public override void initialize()
        {
            Console.WriteLine("Cricket Game Initialized! Start playing.");
        }

        public override void startPlay()
        {
            Console.WriteLine("Cricket Game Started. Enjoy the game!");
        }
    }
}
