using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerAdapterExample
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
    }
}