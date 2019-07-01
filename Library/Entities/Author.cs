using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Author
    {
        public Author()
        {

        }

        public Author(string name)
        {
            this.Name = name;
        }

        public Author(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
        }

        public int ID { get; set; }

        public string Name { get; set; }
    }
}
