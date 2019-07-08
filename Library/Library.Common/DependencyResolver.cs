using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.BLL.Interface;
using Library.BLL;
using Library.DAL.Interface;
using Library.DAL;

namespace Library.Common
{
    public static class DependencyResolver
    {
        private static IAuthorDao _authorDao;

        public static IAuthorDao AuthorDao => _authorDao ?? (_authorDao = new AuthorDao());

        private static IAuthorLogic _authorLogic;

        public static IAuthorLogic AuthorLogic => _authorLogic ?? (_authorLogic = new AuthorLogic(AuthorDao));


        private static IBookDao _bookDao;

        public static IBookDao BookDao => _bookDao ?? (_bookDao = new BookDao());

        private static IBookLogic _bookLogic;

        public static IBookLogic BookLogic => _bookLogic ?? (_bookLogic = new BookLogic(BookDao));


        private static IBookLanguageDao _bookLanguageDao;

        public static IBookLanguageDao BookLanguageDao => _bookLanguageDao ?? (_bookLanguageDao = new BookLanguageDao());

        private static IBookLanguageLogic _bookLanguageLogic;

        public static IBookLanguageLogic BookLanguageLogic => _bookLanguageLogic ?? (_bookLanguageLogic = new BookLanguageLogic(BookLanguageDao));


        private static IGenreDao _genreDao;

        public static IGenreDao GenreDao => _genreDao ?? (_genreDao = new GenreDao());

        private static IGenreLogic _genreLogic;

        public static IGenreLogic GenreLogic => _genreLogic ?? (_genreLogic = new GenreLogic(GenreDao));


        private static IPublishingHouseDao _publishingHouseDao;

        public static IPublishingHouseDao PublishingHouseDao => _publishingHouseDao ?? (_publishingHouseDao = new PublishingHouseDao());

        private static IPublishingHouseLogic _publishingHouseLogic;

        public static IPublishingHouseLogic PublishingHouseLogic => _publishingHouseLogic ?? (_publishingHouseLogic = new PublishingHouseLogic(PublishingHouseDao));


        private static IReaderDao _readerDao;

        public static IReaderDao ReaderDao => _readerDao ?? (_readerDao = new ReaderDao());

        private static IReaderLogic _readerLogic;

        public static IReaderLogic ReaderLogic => _readerLogic ?? (_readerLogic = new ReaderLogic(ReaderDao));


        private static IReadersBooksDao _readersBooksDao;

        public static IReadersBooksDao ReadersBooksDao => _readersBooksDao ?? (_readersBooksDao = new ReadersBooksDao());

        private static IReaderBooksLogic _readersBooksLogic;

        public static IReaderBooksLogic ReadersBooksLogic => _readersBooksLogic ?? (_readersBooksLogic = new ReadersBooksLogic(ReadersBooksDao));


        private static IBookInfoDao _bookInfoDao;

        public static IBookInfoDao BookInfoDao => _bookInfoDao ?? (_bookInfoDao = new BookInfoDao());

        private static IBookInfoLogic _bookInfoLogic;

        public static IBookInfoLogic BookInfoLogic => _bookInfoLogic ?? (_bookInfoLogic = new BookInfoLogic(BookInfoDao));
    }
}
