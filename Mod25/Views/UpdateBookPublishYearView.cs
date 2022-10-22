using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class UpdateBookPublishYearView
    {
        public static void Show()
        {
            BookList.Show(BookRepository.AllBooksSortedByTitle());
            Console.WriteLine();
            Console.Write("Введите внутренний иденьтификатор книги, что бы изменить её год издания:");
            var bookId = int.Parse(Console.ReadLine());
            Console.Write("Введите новый год издания: ");
            var newPublishYear = int.Parse(Console.ReadLine());

            try
            {
                BookRepository.ChangePublishYear(bookId,newPublishYear);
                Console.WriteLine("Книга обновлена успешно.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Обновление книги прервалось ошибкой.");
                Console.WriteLine(ex.Message);
            }
        }

    }
}
