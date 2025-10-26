using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_7
{
    abstract class MediaPlayer
    {
        public abstract void Play();

        public virtual void Stop()
        {
            Console.WriteLine("Playback stopped.");
        }

        public void Play(string quality)
        {
            Console.WriteLine($"Playing media in {quality} HD.");
        }
    }
}
