using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod25.Views
{
    internal class CountBookByGenreView
    {
        public static void Show()
        {
            Console.WriteLine("Введите название жанра: ");
            var genre = Console.ReadLine();

            try
            {
                Console.Write("Количество книг этого жанра в библиотеке: ");
                Console.WriteLine(BookRepository.CountBooksByGenre(genre));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
