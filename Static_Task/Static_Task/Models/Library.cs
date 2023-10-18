using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Task.Models
{
    internal class Library
    {
        public int BookLimit { get; set; }
        Book[] Books = new Book[0];

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if(Books.Length <= BookLimit)
            {
                Array.Resize(ref Books, Books.Length + 1);
                Books[Books.Length - 1] = book;
            }
            else
            {
                Console.WriteLine("Array is full already");
            }
        }

        public Book GetBookById(int? id)
        {
            foreach(Book book in Books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
    }
}
