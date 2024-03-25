using System;

namespace ExtensionMethods
{
    //What are EntenSionMethods ?
    //EntensionMethods allow us to add methods to existing class without :
    //      changing its source code.
    //      creating new class that inherits from it.

    // We mostly use extension methods as opposed to creating them.
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is long description which repeats itself. This is long description which repeats itself. This is long description which repeats itself.";
            var shortPost = post.Shorten(5);
            Console.WriteLine(shortPost);
        }


    }
}
