using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_7
{
    class VideoPlayer: MediaPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Playing video...");
        }
        public override void Stop()
        {
            Console.WriteLine("Video playback stopped.");
        }
    }
}
