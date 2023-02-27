using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionandgeneric
{
    internal class BookList
    {
        private List<Book> list = new List<Book>();
        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }
        public void ShowList()
        {
            list.Sort();
            foreach(Book b in list) 
                b.Show();
        }
        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                AddBook();
                n--;
            }
        }
    }
}
