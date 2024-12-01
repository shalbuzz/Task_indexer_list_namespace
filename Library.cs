using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task_indexer_list
{
    public class Library
    {

        List<Book> books = new List<Book>();

        public Book this[int index]
        {
            get => books[index];


        }

        public int BooksCount => books.Count;

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.Name.Contains(value))
                {
                    result.Add(book);
                }
            }
            return result;

        }





        public Book FindBookByCode(string code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                {
                    return book;
                }
            }
            return null;
        }

        public void RemoveAllBooksByName(string value)
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Name.Contains(value))
            //    {
            //        books.RemoveAt(i);
            //    }
            //}

            foreach(var book in books)
            {
                if (book.Name.Contains(value))
                {
                    books.Remove(book);
                    return;
                }
            }
        }

        public List<Book> SearchBooks(string value)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.Name.Contains(value) ||
                    book.AuthorName.Contains(value) ||
                    book.PageCount.ToString().Contains(value))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public List<Book> FindAllBooksByPageCountRange(int minPage, int maxPage)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (book.PageCount >= minPage && book.PageCount <= maxPage)
                {
                    result.Add(book);
                }
            }
            return result;
        }

        public void RemoveBookByCode(string value)
        {
            //for (int i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Code.Equals(value))
            //    {
            //        books.RemoveAt(i);
            //    }
            //}

            foreach (var book in books)
            {
                if (book.Code.Equals(value)) {
                    books.Remove(book);
                    return;
                }
            }
        }
    }
}
