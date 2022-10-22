using Mod25.Repositories;
using Mod25.Views.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class DeleteUserView
    {
        public static void Show()
        {
            UserList.Show(UserRepository.AllUsers());
            Console.WriteLine();
            Console.Write("Введите внутренний иденьтификатор пользователя:");
            var userId = int.Parse(Console.ReadLine());

            try
            {
                UserRepository.Delete(UserRepository.FindById(userId));
                Console.WriteLine("Пользователь удален успешно.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Удаление пользователя прервалось ошибкой.");
                Console.WriteLine(ex.Message);
            }
        }

    }
}
