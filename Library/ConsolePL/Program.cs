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
                        MainCommands.GetBooksList(bookInfoLogic);
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

                        MainCommands.GetReaderInfo(id, readerLogic, bookInfoLogic, readerBooksLogic);
                        break;

                    case "3":
                        Console.WriteLine("Войти в профиль");
                        Console.Write("Введите имя читателя: ");
                        string readerName = Console.ReadLine();
                        Console.Write("Введите логин: ");
                        string login = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        string password = Console.ReadLine();

                        int idReader = MainCommands.SignIn(readerName, login, password, readerLogic);

                        if (idReader != -1)
                        {
                            MainCommands.GetReaderInfo(idReader, readerLogic, bookInfoLogic, readerBooksLogic);
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

                                        MainCommands.AddBookToReaderList(idBook, idReader, readerBooksLogic, bookLogic, readerLogic);
                                        break;

                                    case "2":
                                        Console.Write("Введите id книги: ");

                                        while (!int.TryParse(Console.ReadLine(), out idBook) || idBook < 1)
                                        {
                                            Console.WriteLine("input is wrong");
                                            Console.Write("Введите id книги: ");
                                        }

                                        MainCommands.DeleteBookFromReaderList(idBook, idReader, readerBooksLogic);
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
                        while(MainCommands.IsExistingLogin(log, readerLogic))
                        {
                            Console.Write("Данный логин уже существует. Введите другой: ");
                            log = Console.ReadLine();
                        }

                        Console.Write("Введите пароль: ");
                        string pass = Console.ReadLine();

                        readerLogic.Add(new Reader(name, age, log, pass));
                        break;

                    case "5":
                        Console.WriteLine("Поиск по названию книги");
                        Console.Write("Введите название: ");
                        MainCommands.BookSearch(Console.ReadLine(), bookLogic);
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
