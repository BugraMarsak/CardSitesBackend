using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Constants;

namespace Business.Concrete
{
    public class RaceManager : IRaceService
    {
        IRaceDal _raceDal;

        public RaceManager(IRaceDal raceDal)
        {
            _raceDal = raceDal;
        }

        public IDataResult<List<Race>> GetAll()
        {
            return new SuccessDataResult<List<Race>>(_raceDal.GetAll());
        }
    }
}
