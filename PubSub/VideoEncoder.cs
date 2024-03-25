using System;
using System.Threading;

namespace PubSub
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder //The Publisher - It needs to send Message to Subs i.e. need delegate (agreement) to call method in subscriber
    {
        // Define Delegate- Determines signature of subscribers.
        // Define Event Based on delegate
        // Raise the Event- This is responsible to notify Subscribers.
        //public delegate void VideoEncodedEventHandler (object source, VideoEventArgs args);

        public event EventHandler<VideoEventArgs> VideoEncoded;
      //  public event EventHandler VideoEncoding; --- Without Return.
       
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding Video... {video.Title}");
            Thread.Sleep(3000);
            Console.WriteLine($"Encoded video with ID {video.Id}");
            OnVideoEncoded(video);
        }
        //Raising the Event-Step 3 To notify Subscribers
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
