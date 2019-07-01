using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class AuthorDao : IAuthorDao
    {
        public void Add(Author author)
        {
            BaseDao.Add("AddAuthor", author);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteAuthor", id);
        }

        public IEnumerable<Author> GetAll()
        {
            return BaseDao.GetAll<Author>("Select * from Author");
        }
    }
}
