using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_7
{
    class AudioPlayer: MediaPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Playing audio...");
        }
        public override void Stop()
        {
            Console.WriteLine("Audio playback stopped.");
        }
    }
}
