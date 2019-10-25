using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    class VideoPost:Post
    {
        // member fields
        protected bool running = false;
        protected int currDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, bool isPublic, string sendByUsername, string videoURL, int length)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public void Play()
        {
            if(!running)
            {
                running = true;
                Console.WriteLine("Can't play song already playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                running = false;
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            } else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(running)
            {
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }


        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2} at - {3} with a duration of: {4}",
                this.ID, this.Title, this.SendByUsername, this.VideoURL, this.Length);
        }


    }
}
