using System;

namespace PubSub
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"Message Service: Sending an SMS {e.Video.Title}");
        }
    }
}
