using Business.Abstract;
using Business.BusinessAspects.Autofac;
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

            public IResult AddTransactionalTest(Card card)
            {
                throw new NotImplementedException();
            }

            public IDataResult<List<Card>> GetAll()
            {
                
                return new SuccessDataResult<List<Card>>(_cardDal.GetAll(), Messages.ProductsListed);
            }

            public IDataResult<List<Card>> GetAllByCardTypeId(int id)
            {
                return new SuccessDataResult<List<Card>>(_cardDal.GetAll(p => p.CardTypeId == id));
            }

            public IDataResult<Card> GetbyId(int cardId)
            {
                throw new NotImplementedException();
            }

            public IDataResult<Card> GetbyName(string cardName)
            {
                return new SuccessDataResult<Card>(_cardDal.Get(p => p.CardName == cardName));
            }
    
            public IDataResult<List<Card>> GetByUnitPrice(decimal min, decimal max)
            {
                throw new NotImplementedException();
            }

            public IDataResult<List<CardDetailDto>> GetCardDetails()
            {
                return new SuccessDataResult<List<CardDetailDto>>(_cardDal.GetCardDetails());

            }

            public IResult Update(Card card)
            {
                        throw new NotImplementedException();
            }
     }
}

