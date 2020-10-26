using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    class ActionComicBook: ComicBook
    {
        double age_min;

        public double Age_min
        {
            get => age_min;
            set
            {
                if (this.age_min < 0)
                    age_min = 16;
                else
                    this.age_min = value;
            }
        }

        public ActionComicBook(string name_book, int num_book, string author, DateTime d, double age_min) : base(name_book,num_book,author,d)
        {
            Age_min = age_min;
        }

        public override string Summarize()
        {
            return "This action comic book is for ages greather than "+ Age_min+" years old " ;
        }

        public override string ToString()
        {
            return base.ToString() + "Min age: " + Age_min;
        }

    }
}
