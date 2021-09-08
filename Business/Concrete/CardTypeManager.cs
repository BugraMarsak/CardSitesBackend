using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
