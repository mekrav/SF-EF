using Mod25.Entities;
using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class AddBookView
    {
        public static void Show()
        {
            Console.WriteLine("Введите информацию о книге.");
            Console.Write("Название: "); 
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Жанр: ");
            string genre = Console.ReadLine();
            Console.Write("Год издания: ");
            int year = int.Parse(Console.ReadLine());

            try
            {
                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Genre = genre,
                    Year = year
                };
                BookRepository.Add(book);
                Console.WriteLine("Книга успешно добавлена.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Добавление книги прервалось ошибеой.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}