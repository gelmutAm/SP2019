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
    public class Program
    {
        public static List<ReadersBooks> GetConcreteReaderBooks(int id, IReaderBooksLogic readerBooksLogic)
        {
            List<ReadersBooks> result = new List<ReadersBooks>();

            foreach(var item in readerBooksLogic.GetAll().ToList())
            {
                if(item.IDReader == id)
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

            for(int i = 0; i < readersBooks.Count; i++)
            {
                foreach(var item in bookInfoLogic.GetAll().ToList())
                {
                    if(readersBooks[i].IDBook == item.ID)
                    {
                        books.Add(item);
                    }
                }
            }

            foreach(var item in readerLogic.GetAll().ToList())
            {
                if(item.ID == id)
                {
                    Console.WriteLine($"{item.Name} {item.Age}");
                }
            }

            foreach(var item in books)
            {
                Console.WriteLine($"{item.ID}. {item.Title} | {item.Author} | {item.Genre} | {item.BookLanguage} | {item.PublishingHouse}");
            }
        }

        public static void GetBooksList(IBookInfoLogic bookInfoLogic)
        {
            foreach(var item in bookInfoLogic.GetAll().ToList())
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
            foreach(var item in bookLogic.GetAll().ToList())
            {
                if(name == item.Title)
                {
                    Console.WriteLine($"{item.ID}. {item.Title} {item.IDAuthor} {item.IDGenre} {item.IDLanguage} {item.IDPublishingHouse}");
                }
            }
        }

        public static int SignIn(string readerName, string login, string password, IReaderLogic readerLogic)
        {
            foreach(var item in readerLogic.GetAll().ToList())
            {
                if(item.Name == readerName && item.Login == login && item.Password == password)
                {
                    return item.ID;
                }
            }

            return -1;
        }

        public static void AddBookToReaderList(int bookID, int readerID, IReaderBooksLogic readerBooksLogic)
        {
            readerBooksLogic.Add(new ReadersBooks(readerID, bookID));
        }

        public static void DeleteBookFromReaderList(int bookID, int readerID, IReaderBooksLogic readerBooksLogic)
        {
            int id = -1;

            foreach(var item in readerBooksLogic.GetAll().ToList())
            {
                if(item.IDBook == bookID && item.IDReader == readerID)
                {
                    id = item.ID;
                }
            }

            if (id != -1)
            {
                readerBooksLogic.DeleteById(id);
            }
        }

        public static void Main(string[] args)
        {
            IBookLogic bookLogic = DependencyResolver.BookLogic;
            IBookInfoLogic bookInfoLogic = DependencyResolver.BookInfoLogic;
            IReaderLogic readerLogic = DependencyResolver.ReaderLogic;
            IReaderBooksLogic readerBooksLogic = DependencyResolver.ReadersBooksLogic;

            bool inputComplete = false;

            while (!inputComplete)
            {
                Console.WriteLine();
                Console.WriteLine("1. Получить список книг");
                Console.WriteLine("2. Получить информацию о читателе");
                Console.WriteLine("3. Войти в профиль");
                Console.WriteLine("4. Зарегистрироваться");
                Console.WriteLine("5. Поиск информации о книге по названию");
                Console.WriteLine("6. Выход");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Получить список книг");
                        GetBooksList(bookInfoLogic);
                        break;

                    case "2":
                        Console.WriteLine("Получить информацию о читателе");
                        Console.Write("Введите id читателя: ");

                        int id;
                        while (!int.TryParse(Console.ReadLine(), out id) || id < 1)
                        {
                            Console.WriteLine("input is wrong");
                            Console.Write("Введите id читателя: ");
                        }

                        GetReaderInfo(id, readerLogic, bookInfoLogic, readerBooksLogic);
                        break;

                    case "3":
                        Console.WriteLine("Войти в профиль");
                        Console.Write("Введите имя читателя: ");
                        string readerName = Console.ReadLine();
                        Console.Write("Введите логин: ");
                        string login = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        string password = Console.ReadLine();

                        int idReader = SignIn(readerName, login, password, readerLogic);

                        if (idReader != -1)
                        {
                            GetReaderInfo(idReader, readerLogic, bookInfoLogic, readerBooksLogic);
                            bool readerInputComplete = false;

                            while (!readerInputComplete)
                            {
                                Console.WriteLine("1. Добавить книгу");
                                Console.WriteLine("2. Удалить книгу");
                                Console.WriteLine("3. Выйти из профиля");

                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Console.Write("Введите id книги: ");

                                        int idBook;
                                        while (!int.TryParse(Console.ReadLine(), out idBook) || idBook < 1)
                                        {
                                            Console.WriteLine("input is wrong");
                                            Console.Write("Введите id книги: ");
                                        }

                                        AddBookToReaderList(idBook, idReader, readerBooksLogic);
                                        break;

                                    case "2":
                                        Console.Write("Введите id книги: ");

                                        while (!int.TryParse(Console.ReadLine(), out idBook) || idBook < 1)
                                        {
                                            Console.WriteLine("input is wrong");
                                            Console.Write("Введите id книги: ");
                                        }

                                        DeleteBookFromReaderList(idBook, idReader, readerBooksLogic);
                                        break;

                                    case "3":
                                        readerInputComplete = true;
                                        break;

                                    default:
                                        Console.WriteLine("Вы ввели неправильное значение");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Такого пользователя нет");
                        }

                        break;

                    case "4":
                        Console.WriteLine("Регистрация");
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите возраст: ");
                        int age;
                        while (!int.TryParse(Console.ReadLine(), out age) || age < 1)
                        {
                            Console.WriteLine("input is wrong");
                            Console.Write("Введите возраст: ");
                        }

                        Console.Write("Введите логин: ");
                        string log = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        string pass = Console.ReadLine();

                        readerLogic.Add(new Reader(name, age, log, pass));
                        break;

                    case "5":
                        Console.WriteLine("Поиск по названию книги");
                        Console.Write("Введите название: ");
                        BookSearch(Console.ReadLine(), bookLogic);
                        break;

                    case "6":
                        inputComplete = true;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неправильное значение");
                        break;
                }
            }
        }
    }
}
