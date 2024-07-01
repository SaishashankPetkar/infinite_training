using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Books
    {
        string BookName;
        string AuthorName;
        public Books(string b_name,string a_name)
        {
            BookName = b_name;
            AuthorName = a_name;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name Is {BookName} Written By {AuthorName}");
        }
    }

    class BookShelf
    {
        Books[] book = new Books[5];
        public Books this[int index]
        {
            get
            {
                return book[index];
            }
            set
            {
                book[index] = value;
            }
        }
    }
    class que1
    {
        public static void que1indexercalling()
        {
            string bk_name, auth_name;
            BookShelf book_auth = new BookShelf();
            Console.WriteLine("Enter Names of 5 Books with Auther name");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enetr Details of book {i+1}");
                Console.Write($"Name of Book the {i+1} : ");
                bk_name = Console.ReadLine();
                Console.Write($"Author Name of Book {i + 1} : ");
                auth_name = Console.ReadLine();
                book_auth[i] = new Books(bk_name, auth_name);
            }
            Console.WriteLine();
            Console.WriteLine("The books and authors that you entered are :");
            for (int i = 0; i < 5; i++)
            {
                book_auth[i].Display();
            }
        }
    }
}
