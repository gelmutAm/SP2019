﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.BLL.Interface
{
    public interface IAuthorLogic
    {
        void Add(Author author);

        void DeleteById(int id);

        IEnumerable<Author> GetAll();
    }
}
