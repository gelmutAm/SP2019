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
    public class BookLogic : IBookLogic
    {
        private readonly IBookDao _bookDao;

        public BookLogic(IBookDao bookDao)
        {
            this._bookDao = bookDao;
        }

        public void Add(Book book)
        {
            this._bookDao.Add(book);
        }

        public void Update(Book book)
        {
            this._bookDao.Update(book);
        }

        public void DeleteById(int id)
        {
            this._bookDao.DeleteById(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookDao.GetAll();
        }
    }
}
