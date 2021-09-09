using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RaceManager : IRaceService
    {
        IRaceDal _raceDal;

        public RaceManager(IRaceDal raceDal)
        {
            _raceDal = raceDal;
        }
        [CacheAspect]
        public IDataResult<List<Race>> GetAll()
        {
            return new SuccessDataResult<List<Race>>(_raceDal.GetAll());
        }
    }
}
