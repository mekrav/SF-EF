using Mod25.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views.Helpers
{
    internal static class BookList
    {
        public static void Show(IEnumerable<Book> bookList)
        {
            foreach (Book book in bookList)
            {
                Console.WriteLine(book.ToString());
            }
        }

    }
}
