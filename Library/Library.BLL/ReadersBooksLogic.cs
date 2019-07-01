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
    public class ReadersBooksLogic : IReaderBooksLogic
    {
        private readonly IReadersBooksDao _readersBooksDao;

        public ReadersBooksLogic(IReadersBooksDao readersBooksDao)
        {
            this._readersBooksDao = readersBooksDao;
        }

        public void Add(ReadersBooks readersBooks)
        {
            this._readersBooksDao.Add(readersBooks);
        }

        public void DeleteById(int id)
        {
            this._readersBooksDao.DeleteById(id);
        }

        public IEnumerable<ReadersBooks> GetAll()
        {
            return _readersBooksDao.GetAll();
        }
    }
}
