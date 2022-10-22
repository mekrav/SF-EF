using System;
using Mod25.Views.Helpers;
using Mod25.Repositories;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Views
{
    internal static class MainView
    {
        public static void Show()
        {
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Введите:");
            Console.WriteLine("1 - Что бы посмотреть список книг, отсортированного в алфавитном порядке по названию.");
            Console.WriteLine("2 - Что бы посмотреть список читателей.");
            Console.WriteLine("3 - Что бы добавить книгу.");
            Console.WriteLine("4 - Что бы добавить читателя.");
            Console.WriteLine("5 - Что бы удалить книгу.");
            Console.WriteLine("6 - Что бы удалить читателя.");
            Console.WriteLine("7 - Что бы изменить имя читателя.");
            Console.WriteLine("8 - Что бы изменить год издания книги.");
            Console.WriteLine("9 - Что бы посмотреть список книг определенного жанра и вышедших между определенными годами.");
            Console.WriteLine("10 - Что бы посмотреть количество книг определенного автора в библиотеке.");
            Console.WriteLine("11 - Что бы посмотреть количество книг определенного жанра в библиотеке.");
            Console.WriteLine("12 - Что бы посмотреть есть ли книга определенного автора и с определенным названием в библиотеке.");
            Console.WriteLine("13 - Что бы посмотреть есть ли определенная книга на руках у пользователя.");
            Console.WriteLine("14 - Что бы посмотреть количество книг на руках у пользователя.");
            Console.WriteLine("15 - Что бы посмотреть последнюю вышедшею книгу");
            Console.WriteLine("16 - Что бы посмотреть список всех книг, отсортированный в порядке убывания года их выхода");

            var keyValue = Console.ReadLine();

            switch (keyValue)
            {
                case "1"://посмотреть список книг, отсортированного в алфавитном порядке по названию
                    {
                        BookList.Show(BookRepository.AllBooksSortedByTitle());
                        break;
                    }
                case "2"://посмотреть список читателей
                    {
                        UserList.Show(UserRepository.AllUsers());
                        break;
                    }
                case "3"://добавить книгу
                    {
                        AddBookView.Show();
                        break;
                    }
                case "4"://добавить читателя
                    {
                        AddUserView.Show();
                        break;
                    }
                case "5"://удалить книгу
                    {
                        DeleteBookView.Show();
                        break;
                    }
                case "6"://удалить читателя
                    {
                        DeleteUserView.Show();
                        break;
                    }
                case "7"://изменить имя читателя
                    {
                        UpdateUserNameView.Show();
                        break;
                    }
                case "8"://изменить год издания книги
                    {
                        UpdateBookPublishYearView.Show();
                        break;
                    }
                case "9"://посмотреть список книг определенного жанра и вышедших между определенными годами
                    {
                        BooksGenreBetweenYearsView.Show();
                        break;
                    }
                case "10"://посмотреть количество книг определенного автора в библиотеке
                    {
                        CountBookByAuthorView.Show();
                        break;
                    }
                case "11"://посмотреть количество книг определенного жанра в библиотеке.
                    {
                        CountBookByGenreView.Show();
                        break;
                    }
                case "12"://посмотреть есть ли книга определенного автора и с определенным названием в библиотеке
                    {
                        IsBookInLibraryByTitleAndAuthorView.Show();
                        break;
                    }
                case "13"://посмотреть есть ли определенная книга на руках у пользователя
                    {
                        IsBookTakenView.Show();
                        break;
                    }
                case "14"://посмотреть количество книг на руках у пользователя
                    {
                        CountTakenBooksView.Show();
                        break;
                    }
                case "15"://посмотреть последнюю вышедшею книгу
                    {
                        LastPublishedBookView.Show();
                        break;
                    }
                case "16"://посмотреть список всех книг, отсортированный в порядке убывания года их выхода
                    {
                        try
                        {
                            BookList.Show(BookRepository.AllBooksSortedByYear());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
            }
        }
    }
}