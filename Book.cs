using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ClassLibraryHelper;
namespace Task_indexer_list
{
    public class Book
    {
        private string _code;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public string Code { get; private set; }

        public Book(string name,string authorName, int pageCount, int bookNumber)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;

           
            Code = Helper.CreateBookCode(name, bookNumber);
        }
    } 
        }

    