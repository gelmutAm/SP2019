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
    public class AuthorLogic : IAuthorLogic
    {
        private readonly IAuthorDao _authorDao;

        public AuthorLogic(IAuthorDao authorDao)
        {
            this._authorDao = authorDao;
        }

        public void Add(Author author)
        {
            this._authorDao.Add(author);
        }

        public void DeleteById(int id)
        {
            this._authorDao.DeleteById(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorDao.GetAll();
        }
    }
}
