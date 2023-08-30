using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        //La info del libro no tiene por qué tener el sector y estante de su ubicación. 
        //No le corresponde porque no le permite utilizar esta clase para otras soluciones.

    }
}
