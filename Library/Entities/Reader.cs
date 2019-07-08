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

        public Reader(string name, int age, string login, string password)
        {
            this.Name = name;
            this.Age = age;
            this.Login = login;
            this.Password = password;
        }

        public Reader(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Name = (string)fieldsValuesList[1];
            this.Age = (int)fieldsValuesList[2];
            this.Login = (string)fieldsValuesList[3];
            this.Password = (string)fieldsValuesList[4];
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
