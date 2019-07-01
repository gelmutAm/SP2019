using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class ReadersBooksDao : IReadersBooksDao
    {
        public void Add(ReadersBooks readersBooks)
        {
            BaseDao.Add("AddReadersBooks", readersBooks);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteReadersBooks", id);
        }

        public IEnumerable<ReadersBooks> GetAll()
        {
            return BaseDao.GetAll<ReadersBooks>("Select * from ReadersBooks");
        }
    }
}
