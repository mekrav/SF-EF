using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod25.Views
{
    internal class BooksGenreBetweenYearsView
    {
        public static void Show()
        {
            Console.WriteLine("Введите жанр");
            var genre = Console.ReadLine();
            Console.Write("С какого года: ");
            int sinceYear = int.Parse(Console.ReadLine());
            Console.Write("По какой год: ");
            int toYear = int.Parse(Console.ReadLine());

            try
            {
                BookList.Show(BookRepository.BooksByGenreBetweenYears(genre,sinceYear,toYear));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
