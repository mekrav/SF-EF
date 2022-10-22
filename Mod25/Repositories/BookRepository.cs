using Mod25.Entities;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25.Repositories
{
    internal static class BookRepository
    {
        public static IEnumerable<Book> AllBooks()
        {
            var context = new AppDBContext();
            return context.Books;
        }

        public static Book FindById(int id)
        {
            var context = new AppDBContext();
            return context.Books.FirstOrDefault(b => b.Id == id);
        }

        public static IEnumerable<Book> FindByAuthor(string authorName)
        {
            var context = new AppDBContext();
            return context.Books.Where(b => b.Author == authorName);
        }

        public static IEnumerable<Book> FindByTitle(string title)
        {
            var context = new AppDBContext();
            return context.Books.Where(b => b.Title == title);

        }

        //25.5.4.8
        public static IEnumerable<Book> AllBooksSortedByTitle()
        {
            return AllBooks().OrderBy(b => b.Title);
        }

        //25.5.4.9
        public static IEnumerable<Book> AllBooksSortedByYear()
        {
            return AllBooks().OrderByDescending(b => b.Year);
        }

        public static void Add(Book book)
        {
            var context = new AppDBContext();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public static void Delete(Book book)
        {
            var context = new AppDBContext();
            context.Books.Remove(book);
            context.SaveChanges();
        }

        public static void ChangePublishYear(int bookId, int newPublishYear)
        {
            var context = new AppDBContext();
            var book = context.Books.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
                throw new ArgumentException("Выбран не верный внутренний идентификатор");
            book.Year = newPublishYear;
            context.SaveChanges();
        }

        public static IEnumerable<Book> BooksByGenre(string genre)
        {
            return AllBooks().Where(b => b.Genre == genre);
        }

        public static IEnumerable<Book> BooksBetweenYears(int sinceYear, int toYear)
        {
            return AllBooks().Where(b => b.Year >= sinceYear && b.Year <= toYear);
        }

        //25.5.4.1
        public static IEnumerable<Book> BooksByGenreBetweenYears(string genre, int sinceYear, int toYear)
        {
            return BooksByGenre(genre).Intersect(BooksBetweenYears(sinceYear, toYear));
        }

        //25.5.4.2
        public static int CountBooksByAuthor(string author)
        {
            return FindByAuthor(author).Count();
        }

        //25.5.4.3
        public static int CountBooksByGenre(string genre)
        {
            return BooksByGenre(genre).Count();
        }

        //25.5.4.4
        public static bool IsBookInLibraryByTitleAndAuthor(string title, string author)
        {
            return FindByTitle(title).Intersect(FindByAuthor(author)).Any();
        }

        //25.5.4.5
        public static bool IsBookTaken(Book book, User user)
        {
            return book.UserId == user.Id;
        }

        //25.5.4.6
        public static int CountTakenBooks(User user)
        {
            return user.Books.Count();
        }

        //25.5.4.7
        public static Book LastPublishedBookInLibrary()
        {
            return AllBooks().OrderByDescending(b => b.Year).FirstOrDefault();
        }
    }
}
