using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasks
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Title: {title}  Author: {author}  Pages: {pages}");
        }
    }
}
