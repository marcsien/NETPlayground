using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerAdapterExample
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}