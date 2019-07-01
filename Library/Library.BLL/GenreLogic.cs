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
    public class GenreLogic : IGenreLogic
    {
        private readonly IGenreDao _genreDao;

        public GenreLogic(IGenreDao genreDao)
        {
            this._genreDao = genreDao;
        }

        public void Add(Genre genre)
        {
            this._genreDao.Add(genre);
        }

        public void DeleteById(int id)
        {
            this._genreDao.DeleteById(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return _genreDao.GetAll();
        }
    }
}
