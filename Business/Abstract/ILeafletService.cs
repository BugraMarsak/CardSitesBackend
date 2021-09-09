using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System.Collections.Generic;

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
