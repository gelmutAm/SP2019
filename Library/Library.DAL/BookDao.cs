using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class BookDao : IBookDao
    {
        public void Add(Book book)
        {
            BaseDao.Add("AddBook", book);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteBook", id);
        }

        public IEnumerable<Book> GetAll()
        {
            return BaseDao.GetAll<Book>("Select * from Book");
        }
    }
}
