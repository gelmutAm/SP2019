using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.BLL.Interface
{
    public interface IGenreLogic
    {
        void Add(Genre genre);

        void DeleteById(int id);

        IEnumerable<Genre> GetAll();
    }
}
