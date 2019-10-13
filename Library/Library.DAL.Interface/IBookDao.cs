using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.DAL.Interface
{
    public interface IBookDao
    {
        void Add(Book book);

        void Update(Book book);

        void DeleteById(int id);

        IEnumerable<Book> GetAll();
    }
}
