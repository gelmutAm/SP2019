using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.BLL.Interface;
using Library.DAL;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class BookLanguageLogic : IBookLanguageLogic
    {
        private readonly IBookLanguageDao _bookLanguageDao;

        public BookLanguageLogic(IBookLanguageDao bookLanguageDao)
        {
            this._bookLanguageDao = bookLanguageDao;
        }

        public void Add(BookLanguage bookLanguage)
        {
            this._bookLanguageDao.Add(bookLanguage);
        }

        public void DeleteById(int id)
        {
            this._bookLanguageDao.DeleteById(id);
        }

        public IEnumerable<BookLanguage> GetAll()
        {
            return _bookLanguageDao.GetAll();
        }
    }
}
