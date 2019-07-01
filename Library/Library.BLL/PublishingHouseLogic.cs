using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Library.BLL.Interface;
using Library.DAL;
using Library.DAL.Interface;

namespace Library.BLL
{
    public class PublishingHouseLogic : IPublishingHouseLogic
    {
        private readonly IPublishingHouseDao _publishingHouseDao;

        public PublishingHouseLogic(IPublishingHouseDao publishingHouseDao)
        {
            this._publishingHouseDao = publishingHouseDao;
        }

        public void Add(PublishingHouse publishingHouse)
        {
            this._publishingHouseDao.Add(publishingHouse);
        }

        public void DeleteById(int id)
        {
            this._publishingHouseDao.DeleteById(id);
        }

        public IEnumerable<PublishingHouse> GetAll()
        {
            return _publishingHouseDao.GetAll();
        }
    }
}
