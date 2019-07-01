using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookLanguage
    {
        public BookLanguage()
        {

        }

        public BookLanguage(string name)
        {
            this.Name = name;
        }

        public BookLanguage(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
