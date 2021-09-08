using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILeafletService
    {
        IDataResult<List<LeafletDetailDto>> GetAllByLeafletId(int id);
        IResult Add(Leaflet leaflet);
        IResult Delete(Leaflet leaflet);
        IResult Update(Leaflet leaflet);
        IDataResult<List<LeafletDetailDto>> GetLeafletDetails();
    }
}
