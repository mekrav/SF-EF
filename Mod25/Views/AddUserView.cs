using Mod25.Entities;
using Mod25.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal class AddUserView
    {
        public static void Show()
        {
            Console.WriteLine("Введите информацию о читателе.");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Emil: ");
            string email = Console.ReadLine();

            try
            {
                var user = new User()
                {
                    Name = name,
                    Email = email,

                };
                UserRepository.Add(user);
                Console.WriteLine("Читатель успешно добавлен.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Добавление читателя прервалось ошибеой.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
