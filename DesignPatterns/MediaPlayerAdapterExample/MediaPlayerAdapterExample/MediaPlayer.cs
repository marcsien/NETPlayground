using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerAdapterExample
{
    public interface MediaPlayer
    {
        public void Play(String audioType, String fileName);
    }
}