using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    abstract public class Book
    {
        string name_book;
        int num_book;
        string author;

        public string Name_book { get => name_book; set => name_book = value; }
        public int Num_book
        {
            get => num_book;
            set
            {
                if (this.num_book < 0)
                    num_book = 100;
                else
                    this.num_book = value;
            }
        }
        public string Author { get => author; set => author = value; }

        public Book(string name_book, int num_book, string author)
        {
            Name_book = name_book;
            Num_book = num_book;
            Author = author;
        }

        public override string ToString()
        {
            return "Name of book:" + name_book + " ,Number of page: " + num_book + " ,author: " + author;
        }

        abstract public string Summarize();//כל מחלקה נגזרת ממששת באופן שונה

    }
}
