using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.DAL.Interface
{
    public interface IBookLanguageDao
    {
        void Add(BookLanguage bookLanguage);

        void DeleteById(int id);

        IEnumerable<BookLanguage> GetAll();
    }
}
