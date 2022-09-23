using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerAdapterExample
{
    public interface AdvancedMediaPlayer
    {
        public void PlayVlc(String fileName);
        public void PlayMp4(String fileName);
    }
}
