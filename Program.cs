using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime D1 = new DateTime(2019, 2, 10), D2 = new DateTime(2019, 1, 10);
            List<Book> bookList = new List<Book>();
            bookList.Add(new LibraryBook("Ami and Tami", 246, "disny"));
            bookList.Add(new LibraryBook("How to be a good people?", 350, "professor karso"));
            bookList.Add(new ComicBook("friends", 100, "nathan goshen", new DateTime(2019, 2, 10)));
            bookList.Add(new ComicBook("Hahem hatovim", 500, "avri gilad", D2));
            bookList.Add(new ActionComicBook("Kepten America", 205, "Marvel", D1, 17));
            bookList.Add(new ActionComicBook("Wonder Women", 269, "D.C", new DateTime(2019, 1, 17), 18));
            bookList.Add(new CookBook("MKR the best kitchen", 90, "Ruti Efrat", D1, true));
            bookList.Add(new CookBook("Master Shef", 86, "Haim Cohen", D1, true));
            bookList.Add(new CosherCookBook("We love cosher food!", 159, "Harav Efergan", D2, true, "Rabi Amos"));
            bookList.Add(new CosherCookBook("Dairy food cosher", 143, "Aharony shef", new DateTime(2019, 1, 17), true, "Badaz"));


            BorrowBook(bookList[0], 8);
            BorrowBook(bookList[2], 8);
            BorrowBook(bookList[2], 40);
            BorrowBook(bookList[4], 20);
            BorrowBook(bookList[6], 15);
            BorrowBook(bookList[8], 40);
            Console.WriteLine();
            ReturnBook(bookList[2]);
            ReturnBook(bookList[3]);
            Console.WriteLine();


            foreach (Book item in bookList)
                Console.WriteLine(item.ToString());

            Console.WriteLine();

            foreach (Book item in bookList)
                Console.WriteLine(item.Summarize());

        }
        static public void ReturnBook(Book k)
        {
            Console.Write(k.Name_book + ": ");
            if (k is CookBook)
            {
                if (((CookBook)k).Return() < 0)
                    Console.WriteLine("You'll pay fine about " + ((CookBook)k).Fine());
            }
            else
            {
                int day = ((ComicBook)k).Return();
                if (day > 0)
                    Console.WriteLine("Days left - " + day);
                else
                {
                    day *= -1;
                    Console.WriteLine("you in pigur of " + day + " days");
                }
            }
        }

        public static void BorrowBook(Book k, int days)
        {
            Console.Write("Name of book: " + k.Name_book + " ,Date to borrow: ");
            if (k is LibraryBook)
                Console.WriteLine("not to borrow");
            else
            if (k is CookBook && (((CookBook)k).Borrow(days)))
                Console.WriteLine(((CookBook)k).D);
                       else
               if (((ComicBook)k).Borrow(days))//אם מחזיר אמת אז אפשר להשאיל
                Console.WriteLine((((ComicBook)k).D));
            else
                Console.WriteLine("No alowed to borrow!");
        }
    }
}
