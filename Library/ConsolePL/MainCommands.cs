using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Common;
using Library.BLL;
using Library.BLL.Interface;
using Entities;

namespace ConsolePL
{
    public static class MainCommands
    {
        public static List<ReadersBooks> GetConcreteReaderBooks(int id, IReaderBooksLogic readerBooksLogic)
        {
            List<ReadersBooks> result = new List<ReadersBooks>();

            foreach (var item in readerBooksLogic.GetAll().ToList())
            {
                if (item.IDReader == id)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static void GetReaderInfo(int id, IReaderLogic readerLogic, IBookInfoLogic bookInfoLogic, IReaderBooksLogic readerBooksLogic)
        {
            List<BookInfo> books = new List<BookInfo>();
            List<ReadersBooks> readersBooks = GetConcreteReaderBooks(id, readerBooksLogic);

            int counter = 0;
            foreach (var item in readerLogic.GetAll().ToList())
            {
                counter++;

                if (item.ID == id)
                {
                    Console.WriteLine($"{item.Name} {item.Age}");
                    break;
                }
            }

            if (counter == id)
            {
                for (int i = 0; i < readersBooks.Count; i++)
                {
                    foreach (var item in bookInfoLogic.GetAll().ToList())
                    {
                        if (readersBooks[i].IDBook == item.ID)
                        {
                            books.Add(item);
                        }
                    }
                }

                foreach (var item in books)
                {
                    Console.WriteLine($"{item.ID}. {item.Title} | {item.Author} | {item.Genre} | {item.BookLanguage} | {item.PublishingHouse}");
                }
            }
            else
            {
                Console.WriteLine("Нет читателя с таким id");
            }
        }

        public static void GetBooksList(IBookInfoLogic bookInfoLogic)
        {
            foreach (var item in bookInfoLogic.GetAll().ToList())
            {
                Console.WriteLine($"{item.ID}. {item.Title} | {item.Author} | {item.Genre} | {item.BookLanguage} | {item.PublishingHouse}");
            }
        }

        public static void AddBook(Book book, IBookLogic bookLogic)
        {
            bookLogic.Add(book);
        }

        public static void DeleteBook(int id, IBookLogic bookLogic)
        {
            bookLogic.DeleteById(id);
        }

        public static void BookSearch(string name, IBookLogic bookLogic)
        {
            foreach (var item in bookLogic.GetAll().ToList())
            {
                if (name == item.Title)
                {
                    Console.WriteLine($"{item.ID}. {item.Title} {item.IDAuthor} {item.IDGenre} {item.IDLanguage} {item.IDPublishingHouse}");
                }
            }
        }

        public static int SignIn(string readerName, string login, string password, IReaderLogic readerLogic)
        {
            foreach (var item in readerLogic.GetAll().ToList())
            {
                if (item.Name == readerName && item.Login == login && item.Password == password)
                {
                    return item.ID;
                }
            }

            return -1;
        }

        public static bool IsExistingLogin(string login, IReaderLogic readerLogic)
        {
            foreach(var item in readerLogic.GetAll().ToList())
            {
                if(item.Login == login)
                {
                    return true;
                }
            }

            return false;
        }

        public static void AddBookToReaderList(int bookID, int readerID, IReaderBooksLogic readerBooksLogic, IBookLogic bookLogic, IReaderLogic readerLogic)
        {
            bool isExistedBook = false;

            foreach(var item in bookLogic.GetAll().ToList())
            {
                if(item.ID == bookID)
                {
                    isExistedBook = true;
                }
            }

            if (isExistedBook)
            {
                readerBooksLogic.Add(new ReadersBooks(readerID, bookID));
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }

        public static void DeleteBookFromReaderList(int bookID, int readerID, IReaderBooksLogic readerBooksLogic)
        {
            int id = -1;

            foreach (var item in readerBooksLogic.GetAll().ToList())
            {
                if (item.IDBook == bookID && item.IDReader == readerID)
                {
                    id = item.ID;
                }
            }

            if (id != -1)
            {
                readerBooksLogic.DeleteById(id);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
        }
    }
}
