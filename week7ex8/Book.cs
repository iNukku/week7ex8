using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7ex8
{
    public class Book
    {
        private string title;
        private int year;
        private Publisher bookPublisher;
        private Author[] authors;


        public int Year
        {
            get { return year; }
        }

        public Publisher BookPublisher
        {
            get { return bookPublisher; }
        }

        public string Title
        {
            get { return title; }
        }

        public Author[] GetAuthors()
        {
            return authors;
        }

        public Book(string title, int year, Publisher thePublisher, Author[] theAuthors)
        {
            this.title = title;
            this.year = year;
            this.bookPublisher = thePublisher;
            this.authors = theAuthors;
        }

        public override string ToString()
        {
            return $"Name of the book is {this.title}";
        }
    }
}
