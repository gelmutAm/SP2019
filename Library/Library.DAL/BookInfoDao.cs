using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class BookInfoDao : IBookInfoDao
    {
        public IEnumerable<BookInfo> GetAll()
        {
            return BaseDao.GetAll<BookInfo>("Select * from BookInfo");
        }
    }
}
