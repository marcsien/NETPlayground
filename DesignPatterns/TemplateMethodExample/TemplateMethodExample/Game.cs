using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodExample
{

    public abstract class GameBase
    {
        public virtual void play()
        {

        }
    }

    public abstract class Game : GameBase
    {
        public abstract void initialize();
        public abstract void startPlay();
        public abstract void endPlay();

        //template method
        public sealed override void play()
        {

            //initialize the game
            initialize();

            //start game
            startPlay();

            //end game
            endPlay();
        }
    }
}
