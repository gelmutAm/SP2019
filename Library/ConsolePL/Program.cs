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
                if(item.ID == id)
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public static void GetReaderInfo(int id, IReaderLogic readerLogic, IBookLogic bookLogic, IReaderBooksLogic readerBooksLogic)
        {
            List<Book> books = new List<Book>();
            List<ReadersBooks> readersBooks = GetConcreteReaderBooks(id, readerBooksLogic);

            for(int i = 0; i < readersBooks.Count; i++)
            {
                foreach(var item in bookLogic.GetAll().ToList())
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
                Console.WriteLine($"{item.Title}");
            }
        }

        public static void GetBooksList(IBookLogic bookLogic)
        {
            foreach(var item in bookLogic.GetAll().ToList())
            {
                Console.WriteLine($"{item.ID}. {item.Title} {item.IDAuthor} {item.IDGenre} {item.IDLanguage} {item.IDPublishingHouse}");
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

        public static void Main(string[] args)
        {
            IBookLogic bookLogic = DependencyResolver.BookLogic;
            IReaderLogic readerLogic = DependencyResolver.ReaderLogic;
            IReaderBooksLogic readerBooksLogic = DependencyResolver.ReadersBooksLogic;

            bool inputComplete = false;

            while (!inputComplete)
            {
                Console.WriteLine();
                Console.WriteLine("1. Получить список книг");
                Console.WriteLine("2. Получить информацию о читателе");
                Console.WriteLine("3. Удалить книгу");
                Console.WriteLine("4. Добавить книгу");
                Console.WriteLine("5. Поиск информации о книге по названию");
                Console.WriteLine("6. Выход");
                Console.WriteLine();

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Получить список книг");
                        GetBooksList(bookLogic);
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

                        GetReaderInfo(id, readerLogic, bookLogic, readerBooksLogic);
                        break;

                    case "3":
                        Console.WriteLine("Удалить книгу");
                        Console.Write("Введите id книги: ");

                        while (!int.TryParse(Console.ReadLine(), out id) || id < 1)
                        {
                            Console.WriteLine("input is wrong");
                            Console.Write("Введите id книги : ");
                        }

                        DeleteBook(id, bookLogic);
                        break;

                    case "4":
                        Console.WriteLine("Добавить книгу");
                        Console.Write("Введите название: ");
                        string title = Console.ReadLine();
                        Console.Write("Введите id автора: ");
                        int idAuthor = int.Parse(Console.ReadLine());
                        Console.Write("Введите id жанра: ");
                        int idGenre = int.Parse(Console.ReadLine());
                        Console.Write("Введите id языка: ");
                        int idLanguage = int.Parse(Console.ReadLine());
                        Console.Write("Введите id издательства: ");
                        int idph = int.Parse(Console.ReadLine());

                        Book book = new Book(title, idAuthor, idGenre, idLanguage, idph);

                        AddBook(book, bookLogic);
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
