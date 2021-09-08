using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LeafletManager : ILeafletService
    {
        ILeafletDal _leafletDal;

        public LeafletManager(ILeafletDal leafletDal)
        {
            _leafletDal = leafletDal;
        }
        
        public IResult Add(Leaflet leaflet)
        {
            _leafletDal.Add(leaflet);
            return new SuccessResult(Messages.added);

        }

        public IResult Delete(Leaflet leaflet)
        {
            _leafletDal.Delete(leaflet);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<LeafletDetailDto>> GetAllByLeafletId(int id)
        {
            return new SuccessDataResult<List<LeafletDetailDto>>(_leafletDal.GetByLeafletId(id));
        }
        //[CacheAspect]
        public IDataResult<List<LeafletDetailDto>> GetLeafletDetails()
        {
            return new SuccessDataResult<List<LeafletDetailDto>>(_leafletDal.GetLeafletDetails());
        }
        //[CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Leaflet leaflet)
        {
            _leafletDal.Update(leaflet);
            return new SuccessResult(Messages.ProductAdded);
        }

    }
}
