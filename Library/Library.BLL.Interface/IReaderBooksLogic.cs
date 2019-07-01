using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.BLL.Interface
{
    public interface IReaderBooksLogic
    {
        void Add(ReadersBooks readersBooks);

        void DeleteById(int id);

        IEnumerable<ReadersBooks> GetAll();
    }
}
