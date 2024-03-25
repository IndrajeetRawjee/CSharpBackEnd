using System;

namespace PubSub
{
    public class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService. Sending EMail on Video {e.Video.Title}");
        }
    }
}
