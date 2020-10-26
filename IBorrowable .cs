using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    interface IBorrowable
    {
        bool Borrow(int days);
        int Return(); 
    }

}
