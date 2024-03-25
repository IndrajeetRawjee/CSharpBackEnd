using System;
using System.Linq;

namespace LinqTraining
{
    // What is LINQ?
    //Stands for Language Integrated Query
    // Gives capability to Query Objects.

    // What all can we Query?
    //Objects in Memory, E.g. Collections (LINQ to Object)
    //Databases (LINQ to Entities)
    //XML (LINQ to XML)
    //ADO.NET Dat seta (LinQ to DataSets)
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LinQ Query ( Less Powerful than LinQ Extension Method [Query is converted into LinQ Extension Method] )
            var cheaperBooks =
                from b in books
                where b.price < 10
                orderby b.Title
                select b;


            //LinQ Extension Method ( More Powerful than LinQ Query )
            var cheapBooks = books
                                .Where(b => b.price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);
              
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
