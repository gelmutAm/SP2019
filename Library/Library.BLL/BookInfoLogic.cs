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
    public class BookInfoLogic : IBookInfoLogic
    {
        private readonly IBookInfoDao _bookInfoDao;

        public BookInfoLogic(IBookInfoDao bookInfoDao)
        {
            this._bookInfoDao = bookInfoDao;
        }

        public IEnumerable<BookInfo> GetAll()
        {
            return _bookInfoDao.GetAll();
        }
    }
}
