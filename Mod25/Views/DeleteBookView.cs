using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class DeleteBookView
    {
        public static void Show()
        {
            BookList.Show(BookRepository.AllBooksSortedByTitle());
            Console.WriteLine();
            Console.Write("Введите внутренний иденьтификатор книги:");
            var bookId = int.Parse(Console.ReadLine());

            try
            {
                BookRepository.Delete(BookRepository.FindById(bookId));
                Console.WriteLine("Книга удалена успешно.");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Удаление книги прервалось ошибкой.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}