using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal class IsBookTakenView
    {
        public static void Show()
        {
            BookList.Show(BookRepository.AllBooksSortedByTitle());
            Console.WriteLine();
            Console.Write("Введите внутренний иденьтификатор книги:");
            var bookId = int.Parse(Console.ReadLine());

            UserList.Show(UserRepository.AllUsers());
            Console.Write("Введите внутренний иденьтификатор пользователя:");
            var userId = int.Parse(Console.ReadLine());


            try
            {
                if (BookRepository.IsBookTaken(BookRepository.FindById(bookId), UserRepository.FindById(userId)))
                    Console.WriteLine("Книга на руках у этого читателя.");
                else
                    Console.WriteLine("Выбранная книга не находится на руках у данного читателя.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
