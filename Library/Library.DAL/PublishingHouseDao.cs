using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.DAL.Interface;

namespace Library.DAL
{
    public class PublishingHouseDao : IPublishingHouseDao
    {
        public void Add(PublishingHouse publishingHouse)
        {
            BaseDao.Add("AddPublishingHouse", publishingHouse);
        }

        public void DeleteById(int id)
        {
            BaseDao.DeleteById("PublishingHouse", id);
        }

        public IEnumerable<PublishingHouse> GetAll()
        {
            return BaseDao.GetAll<PublishingHouse>("Select * from PublishingHouse");
        }
    }
}
