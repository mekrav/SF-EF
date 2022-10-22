using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal class IsBookInLibraryByTitleAndAuthorView
    {
        public static void Show()
        {
            Console.WriteLine("Введите информацию о книге.");
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();

            try
            {
                if (BookRepository.IsBookInLibraryByTitleAndAuthor(title, author))
                    Console.WriteLine("Такая книга есть");
                else
                    Console.WriteLine("Такой книги нет");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
