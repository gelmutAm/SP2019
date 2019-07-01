using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class BookLanguageDao : IBookLanguageDao
    {
        public void Add(BookLanguage bookLanguage)
        {
            BaseDao.Add("AddBookLanguage", bookLanguage);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteBookLanguage", id);
        }

        public IEnumerable<BookLanguage> GetAll()
        {
            return BaseDao.GetAll<BookLanguage>("Select * from BookLanguage");
        }
    }
}
