using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod25.Views
{
    internal class LastPublishedBookView
    {
        public static void Show()
        {
            Console.WriteLine("Последняя вышедшая книга:");
            try
            {
                var lpBook = BookRepository.AllBooksSortedByYear().FirstOrDefault();

                Console.WriteLine(lpBook.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
