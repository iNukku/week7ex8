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

            Booklist myBookList = new Booklist();
            myBookList.CreateBooklist();
            List<Book> myListOfBooks = myBookList.GetBookList();

            foreach (Book book in myListOfBooks)
            {
                Console.WriteLine($"Booktitle: {book.Title}");
                Console.WriteLine($"Year: {book.Year}");
                Console.WriteLine($"Publisher: {book.BookPublisher.getTitle()} {book.BookPublisher.FirstName} {book.BookPublisher.LastName}");
                foreach(Author author in book.GetAuthors())
                {
                    Console.WriteLine($"Author : {author.FirstName} {author.LastName}");
                    Console.WriteLine($"Mail of Author : {author.Email}");
                    Console.WriteLine($"Adress of author : {author.Adress}");
                }
                Console.WriteLine("\n ******************* \n ");
            }

            Console.WriteLine("End of booklist \n\n ******************* \n");

            Console.ReadKey();
        }
    }
}
