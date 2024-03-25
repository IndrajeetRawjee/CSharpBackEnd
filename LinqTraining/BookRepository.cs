using System.Collections.Generic;

namespace LinqTraining
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "ADO.Net Step By Step", price = 5},
                new Book(){Title = "ADO.Net MVC", price = 9.99f},
                new Book(){Title = "ADO.Net Wbe API", price = 12},
                new Book(){Title = "ADO.Net Advanced Topic", price = 7},
                new Book(){Title = "ADO.Net Advanced Topic", price = 9}
            };
        }
    }
}
