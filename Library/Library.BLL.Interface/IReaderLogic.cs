using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.BLL.Interface
{
    public interface IReaderLogic
    {
        void Add(Reader reader);

        void DeleteById(int id);

        IEnumerable<Reader> GetAll();
    }
}
