namespace PubSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.Id = 0;
            video.Title = "video one";
            video.Description = "This is the Description of Video One.";

            VideoEncoder videoEncoder = new VideoEncoder();
            MailService mailService = new MailService();
            MessageService messageService = new MessageService();


            //Notifying subscribers about an event.
            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

        }
    }
}
