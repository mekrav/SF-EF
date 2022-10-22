using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod25.Views
{
    internal static class CountBookByAuthorView
    {
        public static void Show()
        {
            Console.WriteLine("Введите имя автора: ");
            var author = Console.ReadLine();

            try
            {
                Console.Write("Количество книг этого автора в библиотеке: ");
                Console.WriteLine(BookRepository.CountBooksByAuthor(author));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
