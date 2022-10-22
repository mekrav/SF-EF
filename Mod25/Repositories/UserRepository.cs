using Mod25.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod25.Repositories
{
    internal static class UserRepository
    {
        public static IEnumerable<User> AllUsers()
        {
            var context = new AppDBContext();
            return context.Users.OrderBy(u => u.Name);
        }

        public static User FindById(int id)
        {
            var context = new AppDBContext();
            return context.Users.FirstOrDefault(u => u.Id == id);
        }

        public static void Add(User user)
        {
            var context = new AppDBContext();
            context.Users.Add(user);
            context.SaveChanges();
        }

        public static void Delete(User user)
        {
            var context = new AppDBContext();
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public static void ChangeName(int userId, string newName)
        {
            var context = new AppDBContext();
            var user = context.Users.FirstOrDefault(u => u.Id == userId);
            if (user == null)
                throw new ArgumentException("Выбран не верный внутренний идентификатор");
            user.Name = newName;
            context.SaveChanges();
        }
    }
}
