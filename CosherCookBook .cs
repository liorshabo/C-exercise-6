using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    class CosherCookBook : CookBook
    {
        string supervision;

        public string Supervision { get => supervision; set => supervision = value; }

        public CosherCookBook(string name_book, int num_book, string author, DateTime c, bool isDamaged, string supervision) : base(name_book, num_book, author, c, isDamaged)
        {
            Supervision = supervision;
        }

        public override string Summarize()
        {
            return "This cosher cooking book is supervised by " + Supervision;

        }

        public override string ToString()
        {
            return base.ToString() + " ,Supervision: " + Supervision;
        }


        public new int Fine()
        {
            int pay = 0;
            int day = (int)(D - DateTime.Now).TotalDays;
            if (IsDamaged == true)
                pay = 200;
            if (day < 0)
            {
                day *= -1;
                pay += day * 12;
            }
            return pay;
        }

    }
}
