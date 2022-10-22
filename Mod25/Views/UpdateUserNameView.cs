using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class UpdateUserNameView
    {
        public static void Show()
        {
            UserList.Show(UserRepository.AllUsers());
            Console.WriteLine();
            Console.Write("Введите внутренний иденьтификатор пользователя имя которого хотите поменять:");
            var userId = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите новое имя пользователя");
            var newName = Console.ReadLine();

            try
            {
                UserRepository.ChangeName(userId, newName);
                Console.WriteLine("Имя пользователя изменено успешно.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Изменение имени пользователя прервалось ошибкой.");
                Console.WriteLine(ex.Message);
            }

        }
    }
}
