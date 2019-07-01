using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class ReaderDao : IReaderDao
    {
        public void Add(Reader reader)
        {
            BaseDao.Add("AddReader", reader);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteReader", id);
        }

        public IEnumerable<Reader> GetAll()
        {
            return BaseDao.GetAll<Reader>("Select * from Reader");
        }
    }
}
