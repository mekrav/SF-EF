using Mod25.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views.Helpers
{
    internal static class UserList
    {
        public static void Show(IEnumerable<User> userList)
        {
            foreach (User user in userList)
            {
                Console.WriteLine("Внутренний идентификатор пользователя: " + user.Id);
                Console.WriteLine("Имя: " + user.Name);
                Console.WriteLine("E-mail:" + user.Email);
                Console.WriteLine("----------");
            }
        }
    }
}
