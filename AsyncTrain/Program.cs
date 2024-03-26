using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AsyncTrain
{
    partial class Program
    {
        // Asyncronous programming helps in avoiding blocking code.
        //How to do?
        //Traditionally: 1) Multi Threading and 2) Call back.
        //New approach since .NET 4.5 :: Async/Await.
        static async Task Main(string[] args)
        {
            var input = Console.ReadLine();
            var asf = new AsyncFunction();

            if (input == "Go")
            {
                await asf.DownloadHTMLAsync("https://msdn.microsoft.com");
            }
        }
    }
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

}
