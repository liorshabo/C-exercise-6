using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    class ComicBook : Book, IBorrowable
    {
        DateTime d;

        public DateTime D { get => d; set => d = value; }


        public ComicBook(string name_book, int num_book, string author, DateTime d) : base(name_book, num_book, author)
        {
            D = d;
        }

        public override string Summarize()
        {
            return "This comic book is for all ages to enjoy ";
        }

        public override string ToString()
        {
            return base.ToString() + " ,Date: " + D.Day + "/" + D.Month + "/" + D.Year+" ";
        }

        public bool Borrow(int days)
        {
            if ((D - DateTime.Now).TotalDays > days)
            {
                D = DateTime.Now.AddDays(days);
                return true;
            }
            return false;
        }
        public int Return()
        {
            return (int)(D - DateTime.Now).TotalDays;
        }

    }
}