using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Core.Aspect.Autofac.Caching;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CardManager : ICardService
    {
        ICardDal _cardDal;

        public CardManager(ICardDal cardDal)
        {
            _cardDal = cardDal;
        }
        //[SecuredOperation("Admin")]
        public IResult Add(Card card)
        {
            _cardDal.Add(card);
            return new SuccessResult(Messages.CardAdded);
        }
         
     
        public IDataResult<List<Card>> GetAllByCardTypeId(int id)
        {
            return new SuccessDataResult<List<Card>>(_cardDal.GetAll(p => p.CardTypeId == id));
        }

      
        public IDataResult<Card> GetbyName(string cardName)
        {
            return new SuccessDataResult<Card>(_cardDal.Get(p => p.CardName == cardName));
        }

        
        public IDataResult<List<CardDetailDto>> GetCardDetails()
        {
            return new SuccessDataResult<List<CardDetailDto>>(_cardDal.GetCardDetails());

        }

    }
}

