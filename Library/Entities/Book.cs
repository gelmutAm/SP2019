using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string title, int idAuthor, int idGenre, int idLanguage, int idPublishingHouse)
        {
            this.Title = title;
            this.IDAuthor = idAuthor;
            this.IDGenre = idGenre;
            this.IDLanguage = idLanguage;
            this.IDPublishingHouse = idPublishingHouse;
        }

        public Book(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Title = (string)fieldsValuesList[1];
            this.IDAuthor = (int)fieldsValuesList[2];
            this.IDGenre = (int)fieldsValuesList[3];
            this.IDLanguage = (int)fieldsValuesList[4];
            this.IDPublishingHouse = (int)fieldsValuesList[5];
        }

        public int ID { get; set; }

        public string Title { get; set; }

        public int IDAuthor { get; set; }

        public int IDGenre { get; set; }

        public int IDLanguage { get; set; }

        public int IDPublishingHouse { get; set; }
    }
}
