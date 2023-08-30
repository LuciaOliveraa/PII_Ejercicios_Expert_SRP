using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public List<Book> BooksList { get ; set; }

        public int LibraryShelve { get ; set; }
        
        public string ShelveNumber;
        public Shelve(string shelveNumber)
        {
            this.ShelveNumber = shelveNumber;
            this.BooksList = new List <Book>();
        }

        public void AddBook(Book book)
        {
            BooksList.Add(book);
        }
    }
}
