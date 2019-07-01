using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class GenreDao : IGenreDao
    {
        public void Add(Genre genre)
        {
            BaseDao.Add("AddGenre", genre);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("DeleteGenre", id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return BaseDao.GetAll<Genre>("Select * from Genre");
        }
    }
}
