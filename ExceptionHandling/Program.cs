using System;
using System.IO;

namespace ExceptionHandling
{
    // Use Try Catch blocks to handle exceptions.
    //Should have global exception handler in the Application.
    //Exception class is parent of all classes. It is most generic one.
    // There can be multiple catch in exception handling. going from most specific to most generic.
    //Default is finally. whenever using unmanaged resources,e.g. Files, Database connections,etc. Make sure it should be disposed off in finally block.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                throw new YoutubeException("could not find ", ex); 
            }
        }
    }

    public class YoutubeException: Exception
    {
        public YoutubeException(string message, Exception innerException): base(message, innerException)
        {

        }
    }
}
