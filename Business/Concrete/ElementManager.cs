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
