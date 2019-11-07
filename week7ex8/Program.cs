using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Publisher> publishers = new List<Publisher>();
            List<Author> authors = new List<Author>();
            List<Book> books = new List<Book>();

            //Add hardcoded publishers
            publishers.Add(new Publisher("Lars", "Larsen", title.Sir));
            publishers.Add(new Publisher("Jens", "Jensen", title.Sir));
            publishers.Add(new Publisher("Jytte", "Andersen", title.Mrs));
            publishers.Add(new Publisher("Jette", "Jensen", title.Miss));

            //Add hardcoded Authors
            authors.Add(new Author("Bent", "Bentsen", "bent@bent.dk", "Kvistvej 4"));
            authors.Add(new Author("Bent", "Larsen", "Lars@bent.dk", "Kystvej 4"));
            authors.Add(new Author("Gitte", "Andersen", "Gitte@bent.dk", "Vænget 2"));
            authors.Add(new Author("Lene", "Nielsen", "Lene@bent.dk", "Rundkørslen 12"));
            authors.Add(new Author("Ulrik", "Oure", "Ulrik@bent.dk", "Vejsvinget 211"));

            // Add hardcoded Books
            books.Add(new Book("Den farlige Musefælde", 2000, publishers[1], new Author[] {authors[1], authors[3] }));
            books.Add(new Book("Den meget farlige Muefælde", 2001, publishers[2], new Author[] { authors[2], authors[3] }));
            books.Add(new Book("Den superfarlige Musefælde", 2005, publishers[3], new Author[] { authors[1], authors[3] }));
            books.Add(new Book("Den ufarlige Musefælde", 2019, publishers[0], new Author[] { authors[0] }));
            books.Add(new Book("Den skjulte Musefælde", 1998, publishers[2], new Author[] { authors[4] }));

            Console.WriteLine(books[0].Title);
            Console.WriteLine(books[4].Title);
            Console.ReadKey();
        }
    }
}
