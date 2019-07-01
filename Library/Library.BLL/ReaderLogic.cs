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
    public class ReaderLogic : IReaderLogic
    {
        private readonly IReaderDao _readerDao;

        public ReaderLogic(IReaderDao readerDao)
        {
            this._readerDao = readerDao;
        }

        public void Add(Reader reader)
        {
            this._readerDao.Add(reader);
        }

        public void DeleteById(int id)
        {
            this._readerDao.DeleteById(id);
        }

        public IEnumerable<Reader> GetAll()
        {
            return _readerDao.GetAll();
        }
    }
}
