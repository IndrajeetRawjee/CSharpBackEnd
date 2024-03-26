using System.IO;
using System.Net;
using System.Threading.Tasks;


namespace AsyncTrain
{
    partial class Program
    {
        public class AsyncFunction
        {
            public async Task DownloadHTMLAsync(string url)
            {
                var webClient = new WebClient();
                var html = await webClient.DownloadStringTaskAsync(url);

                using (var streamWriter = new StreamWriter(@"c:\projects\result.html"))
                {
                    await streamWriter.WriteAsync(html);
                }

            }
        }
    }
}
