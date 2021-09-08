using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILeafletDal : IEntityRepository<Leaflet>
    {
        List<LeafletDetailDto> GetLeafletDetails();
        List<LeafletDetailDto> GetByLeafletId(int leafletId);
    }
}
