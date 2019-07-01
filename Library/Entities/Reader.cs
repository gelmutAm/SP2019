using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reader
    {
        public Reader()
        {

        }

        public Reader(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Reader(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
            this.Age = (int)fieldsValuesList[2];
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
