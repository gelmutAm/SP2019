﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReadersBooks
    {
        public ReadersBooks()
        {

        }

        public ReadersBooks(int idReader, int idBook)
        {
            this.IDReader = idReader;
            this.IDBook = idBook;
        }

        public ReadersBooks(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.IDReader = (int)fieldsValuesList[1];
            this.IDBook = (int)fieldsValuesList[2];
        }

        public int ID { get; set; }

        public int IDReader { get; set; }

        public int IDBook { get; set; }
    }
}
