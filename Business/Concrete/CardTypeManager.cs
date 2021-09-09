using Business.Abstract;
using Core.Aspect.Autofac.Caching;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CardTypeManager : ICardTypeService
    {
        ICardTypeDal _cardTypeDal;

        public CardTypeManager(ICardTypeDal cardTypeDal)
        {
            _cardTypeDal = cardTypeDal;
        }

        public IDataResult<List<CardType>> GetAll()
        {
            return new SuccessDataResult<List<CardType>>(_cardTypeDal.GetAll());
        }

    }
}
