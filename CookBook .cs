using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
        class CookBook : ComicBook
        {
             bool isDamaged;
          
            public bool IsDamaged { get => isDamaged; set => isDamaged = value; }

            public CookBook(string name_book, int num_book, string author, DateTime c, bool isDamaged) : base(name_book, num_book, author,c)
            {
                IsDamaged = isDamaged;
            }

            public override string Summarize()
            {
                return "This cooking book might contain non cosher ingredients ";
            }

            public override string ToString()
            {
                return base.ToString() +(IsDamaged?" ,Damaged!": " ,NOT Damaged") ;
            }

            public new bool Borrow(int days)
            {
                if ((D - DateTime.Now).TotalDays > days)
                    return true; 
                return false;
            }

            public int Fine()
            {
            int pay = 0;
            int day = (int)(D - DateTime.Now).TotalDays;
            if (IsDamaged == true)
                pay = 100;
            if (day < 0)
            {
                day *= -1;
                pay += day * 10;
            }
            return pay;
            }

     

        }
}
