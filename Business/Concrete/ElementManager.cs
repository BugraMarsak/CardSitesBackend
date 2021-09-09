using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ElementManager : IElementService
    {
        IElementDal _elementDal;

        public ElementManager(IElementDal elementDal)
        {
            _elementDal = elementDal;
        }
        
        public IDataResult<List<Element>> GetAll()
        {
            return new SuccessDataResult<List<Element>>(_elementDal.GetAll());
        }
    }
}
