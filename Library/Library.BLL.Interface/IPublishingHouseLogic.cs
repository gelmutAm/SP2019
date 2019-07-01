using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Library.BLL.Interface
{
    public interface IPublishingHouseLogic
    {
        void Add(PublishingHouse publishingHouse);

        void DeleteById(int id);

        IEnumerable<PublishingHouse> GetAll();
    }
}
