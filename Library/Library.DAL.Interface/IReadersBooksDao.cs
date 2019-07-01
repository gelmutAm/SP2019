using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.DAL.Interface
{
    public interface IReadersBooksDao
    {
        void Add(ReadersBooks readersBooks);

        void DeleteById(int id);

        IEnumerable<ReadersBooks> GetAll();
    }
}
