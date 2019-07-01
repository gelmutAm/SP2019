using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.DAL.Interface
{
    public interface IAuthorDao
    {
        void Add(Author author);

        void DeleteById(int id);

        IEnumerable<Author> GetAll();
    }
}
