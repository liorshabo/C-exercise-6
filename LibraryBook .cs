using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    class LibraryBook : Book
    {
        public LibraryBook(string name_book, int num_book, string author)
           : base(name_book, num_book, author)
        { }

        
        public override string Summarize()
        {
            return "This book is for reading inside the library only ";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
