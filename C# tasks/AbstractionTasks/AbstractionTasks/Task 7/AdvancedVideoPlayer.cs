using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_7
{
    sealed class AdvancedVideoPlayer: VideoPlayer
    {
        public override void Play()
        {
            Console.WriteLine("Playing advanced video with enhanced features...");
        }
        public override void Stop()
        {
            Console.WriteLine("Advanced video playback stopped.");
        }
    }
}
