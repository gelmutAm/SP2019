using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BookInfo
    {
        public BookInfo()
        {

        }

        public BookInfo(string title, string author, string genre, string bookLanguage, string publishingHouse)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.BookLanguage = bookLanguage;
            this.PublishingHouse = publishingHouse;
        }

        public BookInfo(List<object> fieldsValuesList)
        {
            this.ID = (int)fieldsValuesList[0];
            this.Title = (string)fieldsValuesList[1];
            this.Author = (string)fieldsValuesList[2];
            this.Genre = (string)fieldsValuesList[3];
            this.BookLanguage = (string)fieldsValuesList[4];
            this.PublishingHouse = (string)fieldsValuesList[5];
        }

        public int ID { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public string BookLanguage { get; set; }

        public string PublishingHouse { get; set; }
    }
}
