using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICardTypeService
    {
        IDataResult<List<CardType>> GetAll();
        //IDataResult<CardType> GetById(int categoryId);
    }
}
