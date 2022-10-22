using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal class CountTakenBooksView
    {
        public static void Show()
        {
            UserList.Show(UserRepository.AllUsers());
            Console.Write("Введите внутренний иденьтификатор пользователя:");
            var userId = int.Parse(Console.ReadLine());

            try
            {
                Console.Write("Количество книг на руках у читателя: ");
                Console.WriteLine(BookRepository.CountTakenBooks(UserRepository.FindById(userId)));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
